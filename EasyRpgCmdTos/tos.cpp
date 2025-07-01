#include "tos.h"
#include "MinHook.h"

#include <Windows.h>
#include <string>

struct {
    decltype(&Edit) edit;
    decltype(&ExternalEditCommand) externalEdit;
    decltype(&Init) init;
    decltype(&Uninit) uninit;
    decltype(&tpc) tpc;
    decltype(&tos) tos;
    decltype(&::tos) tos_orig;
} addr = {};

int __stdcall Init(int arg1) {
    auto lib = LoadLibraryA("OldcmdTos.dll");

    if (!lib) {
        return 0;
    }

    addr.edit = reinterpret_cast<decltype(&Edit)>(GetProcAddress(lib, "_Edit@8"));
    addr.externalEdit = reinterpret_cast<decltype(&ExternalEditCommand)>(GetProcAddress(lib, "_ExternalEditCommand@8"));
    addr.init = reinterpret_cast<decltype(&Init)>(GetProcAddress(lib, "_Init@4"));
    addr.uninit = reinterpret_cast<decltype(&Uninit)>(GetProcAddress(lib, "_Uninit@0"));
    addr.tpc = reinterpret_cast<decltype(&tpc)>(GetProcAddress(lib, "_tpc@8"));
    addr.tos = reinterpret_cast<decltype(&tos)>(GetProcAddress(lib, "_tos@16"));

    if (addr.init) {
        return addr.init(arg1);
    }

    return 0;
}

int __stdcall Edit(int arg1, int arg2) {
    if (addr.edit) {
        return addr.edit(arg1, arg2);
    }

    return 0;
}

int __stdcall ExternalEditCommand(int arg1, int arg2) {
    if (addr.externalEdit) {
        return addr.externalEdit(arg1, arg2);
    }

    return 0;
}

int __stdcall Uninit() {
    if (addr.uninit) {
        return addr.uninit();
    }

    return 0;
}

int __stdcall tpc(int arg1, int arg2) {
    if (addr.tpc) {
        return addr.tpc(arg1, arg2);
    }

    return 0;
}

static int(__stdcall* orig_tos_callback)(const char*);
static int __stdcall tos_callback(const char* formatted_str) {
    //std::string h = formatted_str;
    //h[3] = '?';
    //h += ", EASY";

    return orig_tos_callback(formatted_str);
}

int __stdcall tos(int arg1, EventCommand* cmd, int arg3, int(__stdcall* callback)(const char*)) {
    //int res = addr.tos(arg1, &emptyCmd, arg3, callback);
      
    if (addr.tos) {
        std::string command;

        if (cmd->code >= 2000 && cmd->code <= 2999) {
            std::string cmdstr;
            if (cmd->string) {
                cmdstr = cmd->string;
            }

            command = Format(cmd->code, cmdstr, { cmd->parameters, cmd->parameters + cmd->plen }, arg1, arg3, callback);
        }

        if (command.empty()) {
            orig_tos_callback = callback;
            int res = addr.tos(arg1, cmd, arg3, tos_callback);

            return res;
        }

        addr.tos(arg1, cmd, arg3, callback);

        return callback(command.c_str());
    }

    return 0;
}

void InitHook()  {
    if (MH_Initialize() != MH_OK) {
        return;
    }

    auto lib = LoadLibraryA("cmdTos.dll");

    if (!lib) {
        return;
    }

    addr.edit = reinterpret_cast<decltype(&Edit)>(GetProcAddress(lib, "_Edit@8"));
    addr.externalEdit = reinterpret_cast<decltype(&ExternalEditCommand)>(GetProcAddress(lib, "_ExternalEditCommand@8"));
    addr.init = reinterpret_cast<decltype(&Init)>(GetProcAddress(lib, "_Init@4"));
    addr.uninit = reinterpret_cast<decltype(&Uninit)>(GetProcAddress(lib, "_Uninit@0"));
    addr.tpc = reinterpret_cast<decltype(&tpc)>(GetProcAddress(lib, "_tpc@8"));
    addr.tos_orig = reinterpret_cast<decltype(&tos)>(GetProcAddress(lib, "_tos@16"));

    if (MH_CreateHook(addr.tos_orig, &tos, reinterpret_cast<LPVOID*>(&addr.tos)) != MH_OK)
    {
        return;
    }

    if (MH_EnableHook(addr.tos_orig) != MH_OK)
    {
        return;
    }
}
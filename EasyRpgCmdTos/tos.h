#pragma once

struct EventCommand;

#include <string>
#include <vector>

extern "C" {
    __declspec(dllexport) int __stdcall Edit(int, int);
    __declspec(dllexport) int __stdcall ExternalEditCommand(int, int);
    __declspec(dllexport) int __stdcall Init(int);
    __declspec(dllexport) int __stdcall Uninit();
    __declspec(dllexport) int __stdcall tpc(int, int);
    __declspec(dllexport) int __stdcall tos(int, EventCommand*, int, int(__stdcall* callback)(const char*));
}

struct EventCommand {
    void* unk;
    int code;
    int unk2;
    char* string;
    int plen;
    int* parameters;
};

void InitHook();
std::string Format(int code, std::string string, std::vector<int> parameters, int arg1, int arg3, int(__stdcall* callback)(const char*));

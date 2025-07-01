#include "tos.h"

#include <format>
#include <algorithm>

struct {
	int arg1;
	int arg3;
	int(__stdcall* callback)(const char*);
	std::string str;
} tos_data;

static int(__stdcall* orig_tos_callback)(const char*) = nullptr;
static int __stdcall tos_callback(const char* formatted_str) {
	std::string out = formatted_str;

	auto pos = out.find_first_of('[');
	if (pos == std::string::npos) {
		return 0;
	}

	int bracks = 0;
	for (size_t i = pos; i < out.size(); ++i) {
		auto c = out[i];
		if (c == '[') {
			++bracks;
		}
		else if (c == ']') {
			--bracks;
			if (bracks <= 0) {
				tos_data.str = out.substr(pos, i - pos + 1);
				break;
			}
		}
	}

	return 0;
}

static std::string Var(int* args) {
	EventCommand cmd{};
	int params[] = { 0, 1, 0, 0, 0, 0, 0 };
	cmd.code = 10220;
	cmd.parameters = params;
	cmd.plen = 7;

	int mode = args[0];
	int val = args[1];
	if (mode == 0) {
		return std::to_string(val);
	} else if (mode == 1) {
		params[1] = val;
		tos(tos_data.arg1, &cmd, tos_data.arg3, tos_callback);
		return std::format("V{}", tos_data.str);
	} else if (mode == 2) {
		params[0] = 2;
		tos(tos_data.arg1, &cmd, tos_data.arg3, tos_callback);
		return std::format("V{}", tos_data.str);
	}
	return "???";
}

static std::string OutVar(int* args) {
	EventCommand cmd{};
	int params[] = { 0, 1, 0, 0, 0, 0, 0 };
	cmd.code = 10220;
	cmd.parameters = params;
	cmd.plen = 7;

	int mode = args[0];
	int val = args[1];
	params[1] = val;

	if (mode == 0) {
		tos(tos_data.arg1, &cmd, tos_data.arg3, tos_callback);
		return std::format("V{}", tos_data.str);
	}
	else if (mode == 1) {
		params[0] = 2;
		tos(tos_data.arg1, &cmd, tos_data.arg3, tos_callback);
		return std::format("V{}", tos_data.str);
	} else if (mode == 2) {
		params[0] = 2;
		tos(tos_data.arg1, &cmd, tos_data.arg3, tos_callback);
		return std::format("V[V{}]", tos_data.str);
	}

	return "???";
}

static std::string OutStr(int* args) {
	EventCommand cmd{};
	int params[] = { 0, args[1], 0, 0, 0, 0, 0 };
	cmd.code = 3020;
	cmd.parameters = params;
	cmd.plen = 7;

	int& mode = args[0];
	if (mode == 0) {
		tos(tos_data.arg1, &cmd, tos_data.arg3, tos_callback);
		return std::format("T{}", tos_data.str);
	}
	else if (mode == 1) {
		mode = 0;
		return std::format("T[{}]", OutVar(args));
	}
	else if (mode == 2) {
		mode = 1;
		return std::format("T[{}]", OutVar(args));
	}
	return "???";
}

static std::string Sw(int* args) {
	EventCommand cmd{};
	int params[] = { 0, 1, 0, 0 };
	cmd.code = 10210;
	cmd.parameters = params;
	cmd.plen = 4;

	int mode = args[0];
	int val = args[1];

	if (mode == 0) {
		params[1] = val;
		tos(tos_data.arg1, &cmd, tos_data.arg3, tos_callback);
		return std::format("S{}", tos_data.str);
	} else {
		return std::format("S[{}]", Var(args));
	}
}

static std::string Op(int* args, const std::vector<std::string>& ops) {
	int mode = args[0];
	int val = args[1];

	if (mode == 0) {
		if (val < 0 || val >= ops.size()) {
			return "???";
		}

		return ops[val];
	} else {
		return std::format("Op[{}]", Var(args));
	} 
}

static std::string Str(std::string string, int* args) {
	EventCommand cmd{};
	int params[] = { 0, args[1], 0, 0, 0, 0, 0 };
	cmd.code = 3020;
	cmd.parameters = params;
	cmd.plen = 7;

	int& mode = args[0];
	if (mode == 0) {
		return string;
	} else if (mode == 1) {
		tos(tos_data.arg1, &cmd, tos_data.arg3, tos_callback);
		return std::format("T{}", tos_data.str);
	} else {
		mode = 0;
		return std::format("T[{}]", OutVar(args));
	}
}

static std::string Evt(int* args) {
	int mode = args[0];
	if (mode == 1) {
		mode = 16;
	}
	else if (mode == 2) {
		mode = 32;
	}
	int val = args[1];

	EventCommand cmd{};
	int params[] = { mode , 0, val };
	cmd.code = 12320;
	cmd.parameters = params;
	cmd.plen = 3;

	if (mode == 0) {
		switch (val) {
		case 10001:
			return "[Player]";
		case 10002:
			return "[Boat]";
		case 10003:
			return "[Ship]";
		case 10004:
			return "[Airship]";
		case 10005:
			return "[ThisEvent]";
		default:;
		}
	}

	tos(tos_data.arg1, &cmd, tos_data.arg3, tos_callback);
	return tos_data.str;
}

static std::string Map(int* args) {
	int mode = args[0];
	int val = args[1];

	EventCommand cmd{};
	int params[] = { val, 0, 0, 0 };
	cmd.code = 10810;
	cmd.parameters = params;
	cmd.plen = 4;

	if (val == 0) {
		return "Map[Current]";
	}

	if (mode == 0) {
		tos(tos_data.arg1, &cmd, tos_data.arg3, tos_callback);
		return std::format("Map{}", tos_data.str);
	}
	else {
		return std::format("Map[{}]", Var(args));
	}
}

static std::string GetWithModeAndPos(const std::string str_data, int* args, int& pos) {
	int mode = args[0];
	int arg = args[1];

	std::string ret;
	switch (mode) {
	case 0: {
		auto out = str_data.substr(pos, arg);
		pos += arg;

		std::erase(out, '\r');
		std::erase(out, '\t');
		std::replace(out.begin(), out.end(), '\n', ' ');

		auto new_end = std::unique(out.begin(), out.end(), [](char lhs, char rhs) {
			return (lhs == rhs) && (lhs == ' ');
		});
		out.erase(new_end, out.end());

		if (out.size() > 100) {
			out = out.substr(0, 100) + "...";
		}

		return out;
	}
	default:
		return Str("", args);
	}
}

std::string Format(int code, std::string string, std::vector<int> p, int arg1, int arg3, int(__stdcall* callback)(const char*)) {
	tos_data = { arg1, arg3, callback };
	
	if (code == 2002) {
		p.resize(5);
		std::string face;
		if ((p[4] & 1) > 0) {
			face = ", Face";
		}

		return std::format("@> Trigger Event At: ({}, {}){}", Var(&p[0]), Var(&p[2]), face);
	} else if (code == 2003) {
		return std::format("@> Pathfinder: Move {} to ({}, {})", Evt(&p[0]), Var(&p[2]), Var(&p[4]));
	} else if (code == 2051) {
		return std::format("@> Wait Single Movement: {}, {} Times -> {}", Evt(&p[0]), Var(&p[2]), Var(&p[4]));
	} else if (code == 2055) {
		std::vector<std::string> ops = { "Get Value", "Set Value", "Get Length", "Get Keys", "Get Type", "Remove Key", "Array Push", "Array Pop", "Contains" };

		int pos = 0;
		std::string json_path = GetWithModeAndPos(string, &p[8], pos);

		std::string json;
		if (p[2] == 0) {
			json = GetWithModeAndPos(string, &p[2], pos);
		} else {
			p[2] -= 1;
			json = OutStr(&p[2]);
		}

		std::string type;
		if (p[4] == 0) {
			if (p[5] == 0) {
				type = Sw(&p[6]);
			} else if (p[5] == 1) {
				type = OutVar(&p[6]);
			} else if (p[5] == 2) {
				type = OutStr(&p[6]);
			}
		} else {
			type = std::format("Type[{}][{}]", Var(&p[4]), Var(&p[6]));
		}

		return std::format("@>JSON: {}, {} = {}({})", json_path, type, Op(&p[0], ops), json);
	} else if (code == 2056) {
		p.resize(12);
		std::string name = Str(string, &p[10]);
		return std::format("@> Clone Map Event: {}@{} -> {}({}, {}){}",
			Evt(&p[2]), Map(&p[0]), Evt(&p[8]), Var(&p[4]), Var(&p[6]), name.empty() ? "": ", " + name);
	} else if (code == 2057) {
		p.resize(2);
		return std::format("@> Destroy Map Event: {}", Evt(&p[0]));
	}

	return {};
}
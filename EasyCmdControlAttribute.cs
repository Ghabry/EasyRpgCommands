using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EasyRpgCommands
{
    class EasyCmdControlAttribute : cmdcs.Rm2k3CmdControlAttribute
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpFileName);

        static EasyCmdControlAttribute()
        {
            var harmony = new Harmony("org.easyrpg.commands");

            var targetType = AccessTools.TypeByName("cmdcs.CommandColorManager");
            var targetMethod = AccessTools.Method(targetType, "Contains", new Type[] { typeof(int) });

            var prefix = typeof(EasyCmdControlAttribute).GetMethod(nameof(SupportEasyRpgCommands), BindingFlags.Static | BindingFlags.NonPublic);

            harmony.Patch(targetMethod, prefix: new HarmonyMethod(prefix));

            LoadLibrary("Plugin/EasyCmdTos.dll");
        }

        private static bool SupportEasyRpgCommands(ref bool __result, int code)
        {
            if (code >= 2000 || code <= 2999)
            {
                __result = true;
                return false;
            }

            return true;
        }

        public EasyCmdControlAttribute(int code) : base(code)
        {

        }
        public EasyCmdControlAttribute(int code, string author) : base(code, author)
        {

        }
        public EasyCmdControlAttribute(int code, string author = "", string desc = "") : base(code, author, desc)
        {

        }
        public EasyCmdControlAttribute(int code, string author, string desc_en, string desc_jp) : base(code, author, desc_en, desc_jp)
        {
        
        }
    }
}

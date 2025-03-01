using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyRpgCommands
{
    public static class Helper
    {
        // non-throwing substring when index too large
        public static string SafeSubstring(this string str, int index, int length = -1)
        {
            if (length == -1)
            {
                length = str.Length;
            }

            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            if (index < 0 || index >= str.Length)
            {
                return string.Empty;
            }

            if (index + length > str.Length)
            {
                length = str.Length - index;
            }

            return str.Substring(index, length);
        }
    }
}

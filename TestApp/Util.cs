using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkypeFx
{
    static class Util
    {
        static string invalidChars = System.Text.RegularExpressions.Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars()));
        static string invalidReStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);
        public  static string MakeValidFileName(string name)
        {
            return System.Text.RegularExpressions.Regex.Replace(name, invalidReStr, "_");
        }
    }
}

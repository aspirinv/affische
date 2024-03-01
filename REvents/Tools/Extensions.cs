using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REvents.Tools
{
    public static class Extensions
    {
        public static bool IsEmpty(this string s) => string.IsNullOrWhiteSpace(s);
        public static string IfEmpty(this string s, string def) => string.IsNullOrWhiteSpace(s) ? def : s;
        public static bool NotEmpty(this string s) => string.IsNullOrWhiteSpace(s);
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace REvents.Tools
{
    public static class Extensions
    {
        public static bool IsEmpty(this string s) => string.IsNullOrWhiteSpace(s);
        public static string IfEmpty(this string s, string def) => string.IsNullOrWhiteSpace(s) ? def : s;
        public static bool NotEmpty(this string s) => string.IsNullOrWhiteSpace(s);

        public static string ToSha256(this string source)
        {
            using var s = SHA256.Create();
            return Convert.ToBase64String(s.ComputeHash(Encoding.UTF8.GetBytes(source)));
        }
    }
}

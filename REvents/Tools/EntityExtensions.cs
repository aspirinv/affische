using REvents.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REvents.Tools
{
    public static class EntityExtensions
    {
        public static (string, string) GetTitles(this BackstageEvent e)
        {
            var idx = new[] { " – ", " - ", " | ", " | ", " + " }
                .Select(s => e.name.IndexOf(s))
                .Where(i => i >= 0)
                .FirstOrDefault(-1);

            if (idx >= 0)
            {
                return (e.name.Substring(0, idx), e.name.Substring(idx + 3, e.name.Length - idx - 3));
            }
            return (e.name, string.Empty);
        }

        public static string[] GetTypes(this BackstageEvent e)
            => e.description?
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(x=>x.Trim())
                //.Append(e.type)
                .ToArray()??new string[0];

        public static DateTime GetDate(this BackstageEvent e)
            => DateTime.ParseExact($"{e.date} {e.time.IfEmpty("00:00")}", "MM/dd/yyyy HH:mm", null);
    }
}

using REvents.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REvents.Tools
{
    public static class EntityExtensions
    {
        public static string[] GetTypes(this BackstageEvent e)
            => e.description
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Append(e.type)
                .ToArray();

        public static DateTime GetDate(this BackstageEvent e)
            => DateTime.ParseExact($"{e.date} {e.time}", "MM/dd/yyyy HH:mm", null);
    }
}

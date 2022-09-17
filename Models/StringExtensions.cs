using System;

namespace Searcher.Models
{
    public static class StringExtensions
    {
        public static bool Contains(this string line, string searchWord, bool caseSensitive)
        {
            return line.IndexOf(searchWord, caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}

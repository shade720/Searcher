using System.Collections.Generic;

namespace Searcher.Models
{
    public class SearchInfo
    {
        public string Filename { get; set; }
        public Dictionary<string, int> KeywordsOccurrences { get; set; }
    }
}

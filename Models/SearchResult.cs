using System.Collections.Generic;

namespace Searcher.Models
{
    public class SearchResult
    {
        public SearchInfo[] KeywordsFoundByFiles;
        public Dictionary<string, int> KeywordsFoundOverall;
    }
}

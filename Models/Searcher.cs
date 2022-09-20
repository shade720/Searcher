using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searcher.Models
{
    public static class Searcher
    {
        public static SearchResult SearchKeywordsInDirectory(string directoryPath, string keywordsFilepath, bool caseSensitive)
        {
            if (!Directory.Exists(directoryPath))
            {
                throw new ArgumentException("Directory not found!");
            }
            if (!File.Exists(keywordsFilepath))
            {
                throw new ArgumentException("File with keywords not found!");
            }

            var directoryFiles = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);
            var keywords = File
                .ReadAllLines(keywordsFilepath)
                .Where(keyword => !string.IsNullOrEmpty(keyword))
                .Select(keyword => keyword.Trim())
                .ToArray();

            var resultCollection = new ConcurrentBag<SearchInfo>();
            Parallel.ForEach(directoryFiles, file => resultCollection.Add(SearchInFile (file, keywords, caseSensitive)));
            
            var keywordOccurrencesByFiles = resultCollection.ToArray();
            var keywordOccurrencesOverall = GetKeywordOccurrencesOverall(keywordOccurrencesByFiles);

            return new SearchResult
            {
                KeywordsFoundByFiles = keywordOccurrencesByFiles, 
                KeywordsFoundOverall = keywordOccurrencesOverall
            };
        }

        private static Dictionary<string, int> GetKeywordOccurrencesOverall(IEnumerable<SearchInfo> keywordOccurrencesByFiles)
        {
            return keywordOccurrencesByFiles.Aggregate(new Dictionary<string, int>(), (result, info) =>
            {
                foreach (var keywordOccurrences in info.KeywordsOccurrences)
                {
                    if (result.ContainsKey(keywordOccurrences.Key)) result[keywordOccurrences.Key] += keywordOccurrences.Value;
                    else result[keywordOccurrences.Key] = keywordOccurrences.Value;
                }
                return result;
            });
        }

        private static SearchInfo SearchInFile(string filepath, string[] keywords, bool caseSensitive)
        {
            var searchInfo = new SearchInfo
            {
                Filename = filepath,
                KeywordsOccurrences = keywords.ToDictionary(keyword => keyword, keyword => 0)
            };
            using (var streamReader = new StreamReader(filepath, Encoding.GetEncoding(1251)))
            {
                while (!streamReader.EndOfStream)
                {
                    var str = streamReader.ReadLine();
                    foreach (var keyword in keywords)
                    {
                        if (str.Contains(keyword, caseSensitive)) searchInfo.KeywordsOccurrences[keyword]++;
                    }
                }
            }
            return searchInfo;
        }
    }
}

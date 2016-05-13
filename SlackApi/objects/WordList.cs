using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlackApi.interfaces;

namespace SlackApi.objects
{
    public class WordList : IWordList
    {
        private List<string> GenerateBannedWords()
        {
            return new List<string>()
            {
                "fuck",
                "shit",
                "goddamn",
                "cunt",
                "nigger",
                "bitch",
                "twat",
                "goat fucker"
            };
        }

        private List<string> GenerateWarnWords()
        {
            return new List<string>();
        }

        private List<string> GenerateWhitelistWords()
        {
            return new List<string>();
        } 
        public WordList()
        {
            WarnedWords = GenerateWarnWords();
            WhitelistedWords = GenerateWhitelistWords();
            BannedWords = GenerateBannedWords().Except(WhitelistedWords).ToList();
        }
        public List<string> BannedWords { get; }
        public List<string> WarnedWords { get; }
        public List<string> WhitelistedWords { get; }
    }
}

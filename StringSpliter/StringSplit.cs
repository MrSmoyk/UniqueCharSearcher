using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringSpliter
{
    public class StringSplit
    {
        public StringSplit()
        {
        }

        public char? UniqueChar(string input)
        {
            string[] words = input.Split(" ");
            var wordsList = new List<string>();

            foreach (string word in words)
            {
                var w = Regex.Replace(word, "[!\"#$%&'()*+,-./:;<=>?@\\[\\]^_`{|}~]", string.Empty);
                
                var ww = w.Replace(" ", "");

                if (!string.IsNullOrEmpty(ww))
                    wordsList.Add(ww);

            }

            string chars = string.Empty;

            char? resp = '0';

            foreach (string word in wordsList)
            {
                chars += word.GroupBy(c => c).Where(c => c.Count() == 1).FirstOrDefault()?.Key;
            }

            resp = chars.GroupBy(c => c).Where(c => c.Count() == 1).FirstOrDefault()?.Key;

            return resp;

        }
    }
}

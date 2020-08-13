using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex emojis = new Regex(@"([:]{2}|[*]{2})([A-Z][a-z]{2,})\1");
            Regex coolThreshold = new Regex(@"\d");

            var matchesNums = coolThreshold.Matches(input);
            var matchEmojis = emojis.Matches(input);

            BigInteger thresholdNum = 1;
            for (int i = 0; i < matchesNums.Count; i++)
            {
                thresholdNum *= BigInteger.Parse(matchesNums[i].ToString());
            }

            int validEmojis = matchEmojis.Count;
            List<string> coolEmojis = new List<string>();
            

            for (int i = 0; i < matchEmojis.Count; i++)
            {
                int result = 0;
                string currentEmoji = matchEmojis[i].Groups[2].Value;
                for (int j = 0; j < currentEmoji.Length; j++)
                {
                    result += currentEmoji[j];
                }

                if (result > thresholdNum)
                {
                    coolEmojis.Add(matchEmojis[i].ToString());
                }
                
                
            }

            Console.WriteLine($"Cool threshold: {thresholdNum}");
            Console.WriteLine($"{validEmojis} emojis found in the text. The cool ones are:");
            foreach (var emoji in coolEmojis)
            {
                Console.WriteLine(emoji);
            }






        }
    }
}

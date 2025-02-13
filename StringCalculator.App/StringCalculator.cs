using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculator.App
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimiters = new List<string> { ",", "\n" };
            var match = Regex.Match(numbers, "^//(\\[.*?\\])\\n");

            if (match.Success)
            {
                numbers = numbers.Substring(match.Length);
                var customDelimiters = Regex.Matches(match.Groups[1].Value, "\\[(.*?)\\]")
                    .Cast<Match>()
                    .Select(m => m.Groups[1].Value)
                    .ToList();
                delimiters.AddRange(customDelimiters);
            }
            else if (numbers.StartsWith("//"))
            {
                delimiters.Add(numbers[2].ToString());
                numbers = numbers.Substring(4);
            }

            var numberList = numbers.Split(delimiters.ToArray(), StringSplitOptions.None)
                .Select(int.Parse)
                .ToList();

            var negatives = numberList.Where(n => n < 0).ToList();
            if (negatives.Any())
            {
                throw new ArgumentException("negatives not allowed: " + string.Join(", ", negatives));
            }

            int result = numberList.Where(n => n <= 1000).Sum();
            return result;
        }

    }
}

using Herbert.AdventOfCode.Common;

namespace Herbert.AdventOfCode.Y2023.Day1
{
    public class Day1() : IPuzzle
    {
        Dictionary<string, int> _numbers = new Dictionary<string, int>()
        {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 },
        };

        public Task<(string Puzzle1, string Puzzle2)> Solve(string input)
        {
            var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            int value = 0;
            foreach (var line in lines)
            {
                var numbers = new List<string>();
                var token = string.Empty;
                for (int index = 0; index < line.Length; ++index)
                {
                    char c = line[index];
                    if (char.IsDigit(c))
                    {
                        numbers.Add(c.ToString());
                    }

                    foreach (var number in _numbers)
                    {
                        if (line[index..].StartsWith(number.Key))
                        {
                            numbers.Add(number.Value.ToString());
                        }
                    }
                }

                var twoDigitNumber = numbers.First();
                twoDigitNumber += numbers.Last();
                value += int.Parse(twoDigitNumber);
            }

            return Task.FromResult((value.ToString(), value.ToString()));
        }
    }
}
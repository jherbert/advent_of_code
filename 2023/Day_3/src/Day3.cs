using System.Buffers;
using Herbert.AdventOfCode.Common;

namespace Herbert.AdventOfCode.Y2023.Day3
{
    public class Day3() : IPuzzle
    {
        public Task<(string Puzzle1, string Puzzle2)> Solve(string l)
        {
            var part1 = 0;
            var part2 = 0;

            var input = l.AsSpan();
            var size = input.IndexOf(Environment.NewLine) + 1;
            var search = SearchValues.Create("\n.0123456789");
            var offset = 0;
            int index;

            while ((index = input[offset..].IndexOfAnyExcept(search)) != -1)
            {
                offset += index;

                var (y, x) = Math.DivRem(offset, size);
                var isGear = input[offset] == '*';
                var leftNumber = 0;

                offset += 1;

                for (int y2 = y - 1; y2 <= y + 1; y2++)
                {
                    for (int x2 = x - 1; x2 <= x + 1; x2++)
                    {
                        if (!char.IsAsciiDigit(input[y2 * size + x2]))
                        {
                            continue;
                        }

                        while (--x2 >= 0 && char.IsAsciiDigit(input[y2 * size + x2]))
                        {
                            //`
                        }

                        var number = 0;
                        do
                        {
                            number = number * 10 + (input[y2 * size + ++x2] - '0');
                        }
                        while (char.IsAsciiDigit(input[y2 * size + x2 + 1]));

                        part1 += number;

                        if (isGear)
                        {
                            if (leftNumber > 0)
                            {
                                part2 += leftNumber * number;
                            }
                            else
                            {
                                leftNumber = number;
                            }
                        }
                    }
                }
            }

            return Task.FromResult((part1.ToString(), part2.ToString()));
        }
    }
}
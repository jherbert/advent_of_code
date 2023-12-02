using Herbert.AdventOfCode.Common;

namespace Herbert.AdventOfCode.Y2023.Day2
{
    public class Day2() : IPuzzle
    {
        class Game
        {
            public int GameNumber { get; set; }
            public int Blue { get; set; }
            public int Red { get; set; }
            public int Green { get; set; }
        }

        public Task<(string Puzzle1, string Puzzle2)> Solve(string input)
        {
            var games = new List<Game>();
            foreach (var line in input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries))
            {
                games.Add(ParseGame(line));
            }

            // games with 12 reds, 13 greens and 14 blues
            var filteredGames = games.Where(g => g.Red <= 12 && g.Green <= 13 && g.Blue <= 14);
            var puzzle1Sum = filteredGames.Select(g => g.GameNumber).Sum().ToString() ?? string.Empty;
            var puzzle2Power = games.Select(g => g.Red * g.Green * g.Blue).Sum().ToString() ?? string.Empty;

            return Task.FromResult((puzzle1Sum, puzzle2Power));
        }

        private static Game ParseGame(string line)
        {
            var game = new Game();

            var gameNumber = line[..line.IndexOf(':')].Replace("Game ", string.Empty);
            game.GameNumber = int.Parse(gameNumber);

            foreach (var setLine in line[(line.IndexOf(':') + 1)..].Split(';'))
            {
                var set = setLine.Trim();
                var colors = set.Split(',');

                foreach (var colorLine in colors)
                {
                    var colorCount = colorLine.Trim().Split(' ');
                    var count = int.Parse(colorCount[0]);
                    var color = colorCount[1];

                    switch (color)
                    {
                        case "blue":
                            game.Blue = count > game.Blue ? game.Blue = count : game.Blue;
                            break;
                        case "red":
                            game.Red = count > game.Red ? game.Red = count : game.Red;
                            break;
                        case "green":
                            game.Green = count > game.Green ? game.Green = count : game.Green;
                            break;
                    }
                }
            }

            return game;
        }
    }
}
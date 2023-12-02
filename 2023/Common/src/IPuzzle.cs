namespace Herbert.AdventOfCode.Common;

public interface IPuzzle
{
    Task<(string Puzzle1, string Puzzle2)> Solve(string input);
}
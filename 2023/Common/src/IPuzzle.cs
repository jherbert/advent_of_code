namespace Herbert.AdventOfCode.Common;

public interface IPuzzle
{
    Task<string> Solve(string input);
}
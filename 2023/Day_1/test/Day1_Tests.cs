namespace Herbert.AdventOfCode.Y2023.Day1.Tests;

public class Day1_Tests
{
    [Theory]
    [InlineData(
        """
        Hello World
        """
    )]
    public async Task Solve_Puzzle(string input)
    {
        var puzzle = new Day1();
        var result = await puzzle.Solve(input);

        Assert.Equal("Hello World", result);
    }
}
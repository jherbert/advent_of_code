namespace Herbert.AdventOfCode.Y2023.Day1.Tests;

public class Day2_Tests
{
    [Theory]
    [InlineData(
        """
        Test
        """
    )]
    public async Task Solve_Puzzle(string input)
    {
        var puzzle = new DayN();
        var result = await puzzle.Solve(input);

        Assert.Equal("142", result);
    }

    [Theory]
    [InlineData(
        """
        Test
        """
    )]
    public async Task Solve_Puzzle_PartTwo(string input)
    {
        var puzzle = new DayN();
        var result = await puzzle.Solve(input);

        Assert.Equal("281", result);
    }
}
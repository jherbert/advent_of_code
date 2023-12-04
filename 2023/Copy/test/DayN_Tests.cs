namespace Herbert.AdventOfCode.Y2023.DayN.Tests;

public class DayN_Tests
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
        var (Puzzle1, Puzzle2) = await puzzle.Solve(input);

        Assert.Equal("142", Puzzle1);
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
        var (Puzzle1, Puzzle2) = await puzzle.Solve(input);

        Assert.Equal("281", Puzzle2);
    }
}
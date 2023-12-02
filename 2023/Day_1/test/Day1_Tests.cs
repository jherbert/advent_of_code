namespace Herbert.AdventOfCode.Y2023.Day1.Tests;

public class Day1_Tests
{
    [Theory]
    [InlineData(
        """
        1abc2
        pqr3stu8vwx
        a1b2c3d4e5f
        treb7uchet
        """
    )]
    public async Task Solve_Puzzle(string input)
    {
        var puzzle = new Day1();
        var result = await puzzle.Solve(input);

        Assert.Equal("142", result.Puzzle1);
    }

    [Theory]
    [InlineData(
        """
        two1nine
        eightwothree
        abcone2threexyz
        xtwone3four
        4nineeightseven2
        zoneight234
        7pqrstsixteen
        """
    )]
    public async Task Solve_Puzzle_PartTwo(string input)
    {
        var puzzle = new Day1();
        var result = await puzzle.Solve(input);

        Assert.Equal("281", result.Puzzle2);
    }
}
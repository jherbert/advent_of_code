namespace Herbert.AdventOfCode.Common;

public class Input
{
    public async Task<string> Get(int year, int day)
    {
        var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("Cookie", $"session={Environment.GetEnvironmentVariable("AOC_SESSION")}");

        var input = await httpClient.GetStringAsync($"https://adventofcode.com/{year}/day/{day}/input");

        return input;
    }
}

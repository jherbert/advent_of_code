using Microsoft.Extensions.DependencyInjection;

namespace Herbert.AdventOfCode.Common;

public static class IServiceProviderExtensions
{
    public static async Task ExecutePuzzle(this IServiceProvider hostProvider, int year, int day)
    {
        using IServiceScope serviceScope = hostProvider.CreateScope();
        IServiceProvider provider = serviceScope.ServiceProvider;
        var problem = provider.GetRequiredService<IPuzzle>();
        var input = provider.GetRequiredService<Input>();

        var inputString = await input.Get(year, day);
        var (Puzzle1, Puzzle2) = await problem.Solve(inputString);
        Console.WriteLine($"Puzzle 1: {Puzzle1}");
        Console.WriteLine($"Puzzle 2: {Puzzle2}");
    }
}
using Herbert.AdventOfCode.Common;
using Herbert.AdventOfCode.Y2023.Day1;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddSingleton<Input>();
builder.Services.AddSingleton<IPuzzle, Day1>();
using IHost host = builder.Build();

await host.Services.ExecutePuzzle(2023, 1);

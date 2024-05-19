
using System.Diagnostics;
using DotNetMasterClass.Services;

var integers = ReadIntegers.ReadInts("10KIntegers.txt").ToArray();

var watch = new Stopwatch();

watch.Start();

var triplets = TimeCimplexity.SumOfThree(integers);
watch.Stop();

Console.WriteLine($"We have found numbers with zero sum \"{triplets}");
Console.WriteLine($"Time elapsed: {watch.Elapsed:g}");
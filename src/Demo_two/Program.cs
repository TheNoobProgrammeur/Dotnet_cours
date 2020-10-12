using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading.Tasks;
using Fibonacci;


internal class Program
{
    private static void Main(string[] args)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        // IList<Task<string>> tasks = new List<Task<string>>();
        var res = new ParallelOptions();
        var results = new ConcurrentBag<int[]>();

        Parallel.ForEach(args, res, (arg) =>
        {
            var result = Fibonacci.Fibonacci.Fib(arg);
            results.Add(result);
        });
        
        foreach (var task in results)
        {
            Console.WriteLine($"Resulte : {task}");
        }
        
        stopwatch.Stop();
        Console.WriteLine("Time seconde : "+ stopwatch.Elapsed.TotalSeconds);
    }

}
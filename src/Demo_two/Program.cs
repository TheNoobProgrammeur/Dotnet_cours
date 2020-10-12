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
        //var res = new ParallelOptions();
        
        var results = Fibonacci.Fibonacci.ListFib(args);

        foreach (var task in results)
        {
            Console.WriteLine($"Resulte : {task}");
        }
        
        stopwatch.Stop();
        Console.WriteLine("Time seconde : "+ stopwatch.Elapsed.TotalSeconds);
    }

}
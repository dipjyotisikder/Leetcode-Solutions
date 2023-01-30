using System;
using TribonacciProblem;

public class Program
{
    public static void Main()
    {
        var solution = new TribonacciProblemsSolution();
        var result = solution.Tribonacci(25);
        Console.WriteLine("Result: {0}", result);
    }
}
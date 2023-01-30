using System.Collections.Generic;
using System;

namespace TribonacciProblem
{
    public class TribonacciProblemsSolution
    {
        public int Tribonacci(int n)
        {
            if (n <= 0) return 0;

            var generated = new List<int>
            {
                0
            };

            Console.WriteLine("index {0} total value {1}", 0, 0);

            for (int i = 1; i <= n; i++)
            {
                if (generated.Count < 3)
                {
                    if (generated.Count == 1)
                    {
                        generated.Add(1);
                        Console.WriteLine("index {0} total value {1}", 1, 1);
                    }
                    else if (generated.Count == 2)
                    {
                        generated.Add(1);
                        Console.WriteLine("index {0} total value {1}", 2, 1);
                    }
                }
                else
                {
                    var total = 0;
                    var start = (i - 3);
                    for (int j = start; j <= i - 1; j++)
                    {
                        total = total + generated[j];
                    }
                    generated.Add(total);
                    Console.WriteLine("index {0} total value {1}", i, total);
                }
            }
            return generated[n];
        }
    }
}

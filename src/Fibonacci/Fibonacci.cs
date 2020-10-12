using System;
using System.Collections.Generic;
using System.Linq;

namespace Fibonacci
{
    public class Fibonacci
    {


        public static List<int> ListFib(string[] lignes)
        {
            List<int> res = new List<int>();
            foreach (var ligne in lignes)
            {
                res.Add(Fib(ligne));
            }

            return res; 
        }
        
        public static int Fib(string ligne)
        {
            int i = short.Parse(ligne);
        
            int Fib_two(int i)
            {
                return i switch
                {
                    int when i <= 2 => 1,
                    _ => Fib_two(i - 1) + Fib_two(i - 2)
                };
            }

            var res = Fib_two(i);
            return res;
        }
    }
}

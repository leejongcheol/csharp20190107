using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
 Console.WriteLine(Enumerable.Range(1, 10000).Sum(o => o.ToString().Count(n => n == '7')));
        }
    }
}

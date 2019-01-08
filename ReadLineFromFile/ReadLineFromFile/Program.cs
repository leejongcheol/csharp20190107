using System;
using System.IO;
namespace ReadLineFromFile{
    class Program    {
        static void Main(string[] args)
        {
            int sum = Sum(@"c:\GitHub\number.txt");
            Console.WriteLine($"{sum}");
        }
        static int Sum( string file )
        {
            int sum = 0;
            string[] arr = File.ReadAllLines(file);
            foreach (string s in arr) sum += Int32.Parse(s);
            return sum;
        }
    }
}

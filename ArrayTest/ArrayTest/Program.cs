using System;
using System.Linq;

namespace ArrayTest
{
    class Program
    {
        static int[] iArr = new int[10];  //1차원 배열선언
        static Random r = new Random();
        static void Main(string[] args)
        {
            for (int i = 0; i < iArr.Length; i++)
            {
                iArr[i] = r.Next(1, 10);
            }
            int sum = 0;
            foreach (int i in iArr)
            {
                sum += i;
                Console.Write(i + " ");
            }
            Console.WriteLine($"\n배열합은{sum}");
            Console.WriteLine($"\n배열합은{iArr.Sum()}");
        }
    }
}

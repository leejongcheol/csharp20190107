using System;

namespace SevenCountTest
{
    class SevenCount
    {

        static int n;
        static int count;
        static void Main(string[] args)        {

            Console.WriteLine("일정한 범위 내에서 7이 얼마나 있나 알아보는 프로그램입니다.\n숫자를 입력하세요:");

            while (true)
            {
                bool parsed = Int32.TryParse(Console.ReadLine(), out n);
                if (!parsed)
                {
                    Console.WriteLine("숫자가 범위값을 초과하거나 숫자가 아닙니다. ");
                    Console.WriteLine("다시 입력하세요~. ");
                    continue;
                }
                else
                {
                    break;
                }
            }

            for (int i = 1; i <= n; i++)
            {
                searchSeven(i);
            }
            Console.WriteLine($"{count}");
        }
        public static void searchSeven(int num)
        {
            if (num % 10 == 7) count++;
            if (num > 10) searchSeven(num / 10);
        }
    }

}
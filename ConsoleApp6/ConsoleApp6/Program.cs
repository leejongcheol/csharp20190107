using System;
namespace ConsoleApplication11{
    class Program    {
         static void Main(string[] args)   {
            Func<int, int, int> c = MySum;   //이 델리게이트는 이름있는 외부 메소드를 참조
            Console.WriteLine("1+2={0}", c(1, 2));

            //델리게이트를 이용한 익명 메소드
            Func<int, int, int> c1 = (i, j) => i + j;    //식형식람다, 값을 리턴함        
            Console.WriteLine("3+4={0}", c1(3, 4));
        }
        static int MySum(int i, int j)         {
            return i + j;
        }
    }
}
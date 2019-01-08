using System;
namespace GenericTest{
    //일반화 클래스
    class GTest<T>  {
        internal void Print(T i)
        {
            Console.WriteLine(i);
        }
    }
    //일반화 메소드
    class GTest2
    {
        internal void Print<T>(T i)
        {
            Console.WriteLine(i);
        }
    }
    class Program  {
        static void Main(string[] args)    {
            GTest<int> p1 = new GTest<int>();
            p1.Print(9999);
            GTest<string> p2 = new GTest<string>();
            p2.Print("홍길동");

            GTest2 g2 = new GTest2();
            g2.Print<int>(1111);
            g2.Print<string>("1길동");
        }             
    }
}
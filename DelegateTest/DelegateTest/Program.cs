using System;
namespace DelegateTest{
    class Program    {
        //1 . 선언
        //delegate int SumDelegate(int i, int j);
        static void Main(string[] args)        {
            //2. 생성
            Program p = new Program();
            Func<int, int, int> s =  p.Sum ;
            //3. 실행
            Console.WriteLine( s(1,2) );
        }
        int Sum(int i, int j)        {
            return i + j;
        }
    }
}

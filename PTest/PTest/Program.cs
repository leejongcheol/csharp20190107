using System;
namespace PTest {
    partial class Emp    {  //부분 클래스, Partial Class
        public void GoToOffice()
        {
            Console.WriteLine("사원출근...");
        }
    }

    class Program  {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.GoToOffice();
            e.Getoff();
        }
    }
}

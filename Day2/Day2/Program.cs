using System;
namespace Day2{
    class Emp : object {
        public string Name         {
            get;
            set;
        }
        
        public override string ToString()  //부모크래스의 것을 재정의
        {
            return $"[사원]{Name}";
        }
    }
    class Program  {
        static void Main(string[] args)         {
            Emp e = new Emp();   e.Name = "홍";
            Console.WriteLine(e.Name);            
        }
    }
}

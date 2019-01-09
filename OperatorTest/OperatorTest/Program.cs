using System;
namespace OperatorTest{
    class Add    {
        public int Value { get; set; }
        public static Add operator +(Add a1, Add a2)   {
            Add a3 = new Add();
            a3.Value = a1.Value + a2.Value;
            return a3;
        }
    }
    class Program    {
        static void Main(string[] args)        {
            Add a1 = new Add();  a1.Value = 1;
            Add a2 = new Add();  a2.Value = 2;
            Add a3 = a1 + a2;
            Console.WriteLine(a3.Value);
        }
    }
}

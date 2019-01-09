using System;

namespace IndexerTest
{
    class Emp
    {
        private string[] hobbies = new string[3];        
        public string this[int index]  //인덱서
        {
            get            {                return hobbies[index];            }
            set            {                hobbies[index] = value;            }
    }
        class Program
        {
            static void Main(string[] args)
            {
                Emp e = new Emp();
                e[0] = "등산"; e[1] = "낚시"; e[2] = "골프";
                for (int i = 0; i < 3; i++)                 {     Console.WriteLine($"{e[i]}");     }
            }
        }
    }
}

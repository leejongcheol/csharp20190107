using System;
using System.IO;
namespace CreateDir
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists(@"C:\A"))
            {
                Directory.CreateDirectory(@"C:\A");
            }
        }
    }
}

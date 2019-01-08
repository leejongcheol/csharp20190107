using System;
using System.IO;

class ReadFile
{
    static void Main()
    {
        int sum = SumFromFile(@"c:\GitHub\number.txt");
        Console.WriteLine($"파일의 정수합은{sum}");
    }
    static int SumFromFile(string txtFile)
    {
        int sum = 0;
        string[] arr = File.ReadAllLines(txtFile);
        foreach (string s in arr)
        {
            sum += Int32.Parse(s);
        }
        return sum;
    }
}


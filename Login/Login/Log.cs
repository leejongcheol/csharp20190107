using System;
using System.IO;
namespace Login
{
    class Log
    {
        // C드라이브에 dotnet폴더를만들자.
        public static void WriteLine(string name, string e)
        {
            string filename = @"c:\dotnet\" + name;
            string logtime = DateTime.Now.ToString();
            FileStream aFile = new FileStream(filename, FileMode.OpenOrCreate);
            StreamWriter aWriter = new StreamWriter(aFile, System.Text.Encoding.Default);
            aWriter.WriteLine("[" + logtime + "] ");
            aWriter.WriteLine(e);
            aWriter.Flush();
            aWriter.Close();
        }
    }
}
using System;

namespace DupTest
{
    class Program {
        static void Main(string[] args)
        {
            string s = "abcadbabcf";
            Console.WriteLine(DupCheck(s));
        }
        static char DupCheck(string s)
        {
            int cnt;
            for (int i = 0; i < s.Length; i++)
            {
                cnt = CharCnt(s, s[i]);
                if (cnt == 1) return s[i];
            }
            return '\0';
        }
        static int CharCnt(string s, char c)
        {
            string[] StringArray = s.Split(c);
            return StringArray.Length - 1;
        }
    }
}

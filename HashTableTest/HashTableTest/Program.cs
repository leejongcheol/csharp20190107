using System;
using System.Collections;
using System.Collections.Generic;
namespace HashTableTest{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "홍길동"); h.Add(2, "김길동"); h.Add(3, "정길동");
            foreach(DictionaryEntry d in h)
            {
                Console.WriteLine($"키{d.Key}, 값:{d.Value}");
            }

            SortedList s = new SortedList(h);
            foreach (DictionaryEntry d1 in s)
            {
                Console.WriteLine($"키{d1.Key}, 값:{d1.Value}");
            }

            Dictionary<int, string> d2 = new Dictionary<int, string>();
            d2.Add(1, " 서울"); d2.Add(2, "부산"); d2.Add(3, "대전");
            foreach (KeyValuePair<int, string> k in d2)
            {
                Console.WriteLine($"키{k.Key}, 값:{k.Value}");
            }
        }
    }
}

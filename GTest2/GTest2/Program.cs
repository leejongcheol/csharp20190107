using System;
namespace ConsoleApplication6 {
    class Stack1<T>
    {
        int top = 0;
        T[] ar = new T[10];
        public void Push(T obj)
        {
            ar[top] = obj;
            top++;
        }
        public T Pop()
        {
            top--;
            return ar[top];
        }
    }
    
    class StackTest
    {
        static void Main()
        {
            Stack1<int> s1 = new Stack1<int>();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());

            Stack1<string> s2 = new Stack1<string>();
            s2.Push("1길동");
            s2.Push("2길동");
            s2.Push("3길동");
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());
        }
    }
}
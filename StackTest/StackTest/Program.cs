using System;
using System.Collections;
public class MyStack
{
    public static void Main()
    {
        // Creates and initializes a new Stack.
        Stack myStack = new Stack();
        myStack.Push("OJC");
        myStack.Push("ASIA");
        myStack.Push("Thank You!");
        Console.WriteLine("myStack 의 건수:{0}", myStack.Count);
        //스택의 맨위 하나 꺼냄, 이제는 두개남음
        Console.WriteLine(myStack.Pop());
        //스택의 top 포인터가 가리키는 자료를 리턴, 스택에서 꺼내는것은 아님
        Console.WriteLine(myStack.Peek());

        PrintValues(myStack); //스택에 있는 두값을 출력
    }
    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write("{0} ", obj);
        Console.WriteLine();
    }
}

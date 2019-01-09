using System;
namespace ConsoleApplication1 {
    class EventPublisher  {       
        public event EventHandler MyEvent; //이벤트 정의
        public void Do()  {
            MyEvent?.Invoke(null, null);  //이벤트 발생, 호출
        }
    }
    //구독자 클래스
    class Subscriber    {
        static void Main(string[] args)        {
            EventPublisher p = new EventPublisher();           
            p.MyEvent += new EventHandler(doAction);
            p.Do();
        }
        static void doAction(object sender, EventArgs e)        {
            Console.WriteLine("MyEvent 라는 이벤트 발생...");
        }
    }
}

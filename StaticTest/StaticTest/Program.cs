using System;
namespace StaticTest {  //분류이름
    class Emp    {
        public string name;                 //멤버, 필드, 인스턴스변수
        public static string compName;  //멤버, 필드, 클래스변수
        public void GoToOffice()           //멤버, 메소드(행동)
        {
            Console.WriteLine($"{compName} 소속 {name}(이)가 출근합니다.");
        }
    }
    class EmpTest    {
        static void Main(string[] args)        {
            Emp.compName = "탑크리에듀";
            //e : 객체참조변수
            Emp e = new Emp();  //객체생성
            e.name = "홍길동";   e.GoToOffice();
        }
    }
}

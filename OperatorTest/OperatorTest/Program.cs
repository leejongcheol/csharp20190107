class Emp
{
    public int sal;
    public static bool operator >=(Emp e1, Emp e2)
    {
        return (e1.sal >= e2.sal);
    }
    public static bool operator <=(Emp e1, Emp e2)
    {
        return !(e1.sal >= e2.sal);
    }
}
class Test
{
    static void Main(string[] args)
    {
        Emp e1 = new Emp();
        e1.sal = 1000;
        Emp e2 = new Emp();
        e2.sal = 2000;
        if (e1 >= e2)
        {
            Console.WriteLine("e1이 크다 {0} >= {1}", e1.sal, e2.sal);
        }
        else
        {
            Console.WriteLine("e2가 크다 {0} < {1}", e1.sal, e2.sal);
        }
    }
}
using System;
delegate void Greet();
class program()
{
    static void method1()
    {
        Console.WriteLine("hello student");
    }
    static void method2()
    {
        Console.WriteLine("jjkjk");
    }
    static void Main()
    {
        Greet d = method1;
        d += method2;
        d();
    }
}

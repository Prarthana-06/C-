using System;
delegate void Greet();
class program
{
    static void sayHello()
    {
        Console.WriteLine("Hello Students");
    }
    static void Main()
    {
        Greet greetDelegate = sayHello;
        greetDelegate();
    }
}
using System;
class animal
{
    public void eat()
    {
        Console.WriteLine("hhhh");
    }
}
class dog:animal
{
    public void bark()
    {
        Console.WriteLine("hjkj");
    }
}
class program
{
    static void Main()
    {
        dog d=new dog();
        d.bark();


    }
}
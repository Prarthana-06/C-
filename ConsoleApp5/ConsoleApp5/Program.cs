using System;
class animal
{
    public void eat()
    {
        Console.WriteLine("hjhj");
    }
}
class dog : animal
{
    public void makesound()
    {
        Console.WriteLine("hjjh");
    }
}
class pappy : dog
{
    public void run()
    {
        Console.WriteLine("run");
    }
}
class program
{
    static void Main()
    {
        pappy p=new pappy();
        p.run();
    }
}

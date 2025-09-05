using System;
class car
{
    public void drive()
    {
        Console.WriteLine("car is in driving");
    }

}
class enginee : car
{
    public void show()
    {
        Console.WriteLine("show the enginee");
    }
}
class wheel : enginee
{
    public void rotate()
    {
        Console.WriteLine("wheel is rotating");
    }
}
class programe
{
    static void Main()
    {
        wheel w=new wheel();
        w.rotate();
    }
}
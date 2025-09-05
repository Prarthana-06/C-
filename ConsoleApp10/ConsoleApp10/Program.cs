using System;
class shape
{
    public virtual void Draw()
    {
        Console.WriteLine("drawing a shape");

    }
    public virtual void Erase()
    {
        Console.WriteLine("erase a shape");
    }
}
class circle:shape
{
    public override void Draw()
    {
        Console.WriteLine("draw a circle");
    }
}
class Triangle : shape
{
    public override void Draw()
    {
        Console.WriteLine("draw a triangle");
    }
    public override void Erase()
    {
        Console.WriteLine("erase a triangle");
    }
}
class square : shape
{
    public override void Draw()
    {
        Console.WriteLine("draw sqare");
    }
    public override void Erase()
    {
        Console.WriteLine("erasing a square");
    }
}
class program
{
    shape s;
    shape=new Circle();

}

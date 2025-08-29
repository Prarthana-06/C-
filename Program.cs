using System;
class Shape
{
    public virtual void draw()
    {
        Console.WriteLine("drawing a shape");
    }
    public virtual void erase()
    {
        Console.WriteLine("erasing a shape");
    }
}
class Circle : Shape
{
    public override void draw()
    {
        Console.WriteLine("drawing a circle");
    }
    public override void erase()
    {
        Console.WriteLine("erase a circle");

    }
}
class Triangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("draw a triangle");
    }
    public override void erase()
    {
        Console.WriteLine("erase a tringle");
    }
}
class Square : Shape
{
    public override void draw()
    {
        Console.WriteLine("draw a square");
    }
    public override void erase()
    {
        Console.WriteLine("eraseing a square");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = { new Circle(), new Triangle(), new Square() };
        foreach (Shape S in shapes)
        {
            S.draw();
            S.erase();
        }
    }
}




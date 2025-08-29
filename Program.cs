using System;
interface Resizeable
{
    void resizewidth(int width);
    void resizeheight(int height);
}
class Rectangle : Resizeable
{
    private int width;
    private int height;
    public Rectangle(int w, int h)
    {
        width = w; height = h;
    }
    public void resizewidth(int w)
    {
        width = w;
        Console.WriteLine("width resized to" + width);
    }
    public void resizeheight(int h)
    {
        height = h;
        Console.WriteLine("height resized to" + height);
    }
    public void display()
    {
        Console.WriteLine("rectangle dimension: width=" + width + ",height =" + height);
    }
}
class program
{
    static void Main(string[] args)
    {
        Rectangle r = new Rectangle(10, 20);
        r.display();
        r.resizewidth(30);
        r.resizeheight(40);
        r.display();
        Console.ReadLine();
    }

}


    

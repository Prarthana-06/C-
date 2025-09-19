using System;
class Transport
{
    public virtual void transport()
    {
        Console.WriteLine("go to");

    }
}
class truck : Transport
{
    public override void transport()
    {
        Console.WriteLine("in truck");
    }
}
    class ship : Transport
    {
        public override void transport()
        {
            Console.WriteLine("in ship");
        }
    }
    class arioplane : Transport
    {
        public override void transport()
        {
            Console.WriteLine("in airoplane");
        }
    }
    class pro
    {
        static void Main()
        {
            Transport t = new Transport();
            t.transport();
            Transport t1 = new truck();
            t1.transport();
            Transport t2 = new ship();
            t2.transport();
            Transport t3 = new arioplane();
            t3.transport();
        }
    }

    

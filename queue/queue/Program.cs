using System;
class program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Abc");
        queue.Enqueue("Abcd");
        Console.WriteLine(queue.Dequeue());
    }
}
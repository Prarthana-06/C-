using System;
class program
{
    static void Main()
    {
        Stack<string> stack = new Stack<string>();
        stack.Push("First");
        stack.Push("second");
        Console.WriteLine(stack.Pop());
    }
}
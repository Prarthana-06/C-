using System;
class pro
{
    static void Main()

    {
        Console.WriteLine("enter a sentence");
        string sentence = Console.ReadLine();
        string[]words= sentence.Split(' ');
        Array.Reverse(words);
        Console.WriteLine(string.Join(" ", words));

    }
}

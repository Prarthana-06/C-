using System;
using System.IO;
class Program
{
    static void Main()
    {
        File.WriteAllText("notes.txt", "File handling in c# is easy !\n lests read this file next");
        string content = File.ReadAllText("notes.txt");
        Console.WriteLine(content);
    }
}

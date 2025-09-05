using System;
class program
{
    static void Main()
    {
        Console.WriteLine("enter a string");
        string str=Console.ReadLine();
        Console.WriteLine("asr");
        for (int i = 0;i<str.Length;i++)
        {
            for (int j = 1;j < str.Length - i; j++)
            {
                string sub=str.Substring(i,j);
                Console.WriteLine(sub);
            }
        }
    }
}

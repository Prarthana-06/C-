using System;
class hh
{
    static void Main()
    {
        Console.WriteLine("enter a number");
        int n=Convert.ToInt32(Console.ReadLine());
        int lastdigit = n % 10;
        int firstdigit = n;
        while (firstdigit >= 10)
        {
            firstdigit /= 10;
                }
        Console.WriteLine("firstdigit" + firstdigit);
        Console.WriteLine("last digit" + lastdigit);
    }
}

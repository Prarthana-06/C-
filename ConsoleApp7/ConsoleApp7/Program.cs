using System;
class sum
{
    static void Main()
    {
        Console.WriteLine("enter a number");
        int number=Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int result;
        while(number != 0)
        {
            result = number % 10;
            sum += result;
            number = number / 10;
        }
        Console.WriteLine("sum"+sum);
    }
}


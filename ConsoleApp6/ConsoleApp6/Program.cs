using System;
class amm
{
    static void Main()
    {


        for (int i = 1; i <= 1000; i++)
        {
            int sum = 0, temp = i;
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += digit * digit * digit;
                temp /= 10;


            }

            if (sum == i)
            {
                Console.WriteLine(i);
            }
            
            
                
            
        }
    }
}
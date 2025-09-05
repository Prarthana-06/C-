using System;
class simple
{
    static void Main()
    {
        Console.WriteLine("ENTER 1ST NO");
        int num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter 2nd no");
        int num2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter oprator(+,-,*,/,%)");
        char op=Convert.ToChar(Console.ReadLine());
        int result = 0;
        switch(op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            case '%':
                result = num1 % num2;
                break;
            default:
                Console.WriteLine("invalid");
                break;



        }
        Console.WriteLine("result" + result);
    }
}

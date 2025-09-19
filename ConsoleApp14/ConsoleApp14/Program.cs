using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
class program
{
    static void Main()
    {
        try
        {


            Console.WriteLine(" enter the first numbr");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 / num2;
            Console.WriteLine("result is" + result);

        }
        catch(DivideByZeroException )
        {
            Console.WriteLine("error is cannot divide by zero" );
        }
        catch(FormatException)
        {
            Console.WriteLine("error plese enter vaild number");
        }
        finally
        {
            Console.WriteLine("code to be running ");
        }
        }
}


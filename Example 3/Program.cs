using System;
namespace Example_3;
class Program
{
    static void Main(string[] args)
    {
        int num1 , num2, sum;
        Console.WriteLine("Calculate the sum of two numbers:");
        Console.Write("Input first number:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input secont number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        sum = num1 + num2;
        Console.WriteLine($"The sum of {num1} and {num2} is = {sum}");
        Console.ReadKey();
    }
}

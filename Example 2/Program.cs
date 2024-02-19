using System;

namespace Example_2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hey!!!! Ender a number: ");
        int num =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Your number is:{num}");

        Console.ReadKey();
    }
}

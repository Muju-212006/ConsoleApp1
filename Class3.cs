using System;

namespace ConsoleApp1
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            
            int sum = num1 + num2;

            
            Console.WriteLine("Sum = " + sum);

            Console.ReadLine(); 
        }
    }
}

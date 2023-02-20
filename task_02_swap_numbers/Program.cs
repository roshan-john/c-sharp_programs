using System;

namespace MySpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int secondNum = int.Parse(Console.ReadLine());
            int temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
            Console.WriteLine("The numbers after swapping are "+firstNum+" and "+secondNum);
        }
    }
}
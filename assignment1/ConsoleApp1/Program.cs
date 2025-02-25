// See https://aka.ms/new-console-template for more information
using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            double num1, num2, result;
            char op;
            Console.WriteLine("Please input the first number:");
            s = Console.ReadLine();
            num1 = Double.Parse(s);
            Console.WriteLine("Please input the second number:");
            s = Console.ReadLine();
            num2 = Double.Parse(s);
            Console.WriteLine("Please input an operator:");
            s = Console.ReadLine();
            op = Char.Parse(s);
            switch (op)
            {
                case '+':result = num1 + num2;break;
                case '-':result = num1 - num2;break;
                case '*':result = num1 * num2;break;
                case '/':if (num2 != 0) { result = num1 / num2; }
                         else { Console.WriteLine("The devisor should not be 0!");return; }break;
                default:Console.WriteLine("Invalid operator!");return;
            }
            Console.WriteLine($"The result is {result}");
        }
    }
}
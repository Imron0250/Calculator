using System;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main()
        {

            Console.Write("Pls enter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pls enter the medthod: ");
            string userMethod = Console.ReadLine();
            Console.Write("Pls enter second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            string template = $"{firstNum} {userMethod} {secondNum} = ";
            decimal result = userMethod switch
            {
                "+" => firstNum + secondNum,
                "-" => firstNum - secondNum,
                "*" => firstNum * secondNum,
                "/" => firstNum / secondNum,
                "%" => firstNum % secondNum,
                _ => 0 
            };

            Console.WriteLine($"{template} {result}");




                
                
                
            

            

        }
    }
}
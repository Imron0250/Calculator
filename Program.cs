using System;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Hello, pls enter number below ");
            Console.Write("First number: ");
            string firstUserNum = Console.ReadLine();
            Console.Write("Second Number: ");
            string secondUserNum = Console.ReadLine();

            Console.WriteLine("Information is progressing....");
            decimal firstNumber = Convert.ToDecimal(firstUserNum);
            decimal secondNumber = Convert.ToDecimal(secondUserNum);

            Console.WriteLine("Here are your results");
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
            

        }
    }
}
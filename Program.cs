using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.IO.Compression;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main()
        {


            Console.Write("Do you want to try the system calculator?: ");
            string userChoose = Console.ReadLine();

            if (userChoose == "yes")
            {
                Calculator();
            }
            else 
            {
                Console.WriteLine("Ok fack you ");
            }

            Console.Write("We have a lot of cars, do you want to see them?: ");
            string carChoose = Console.ReadLine();

            if (carChoose == "yes")
            {
                Cars();
            }
            else 
            {
                Console.WriteLine("I guess you gay or girl :(");
            }
        }

        static void Cars()
        {
            string[] cars = {"BMW", "Mersedec", "Folts Wagen", "Bugati"};
            cars[1] = "Damas";
            Array.Sort(cars);
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
        }

        static void Calculator()
        {
            Console.Write("Enter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter method [+, -, *, /, %]: ");
            string userMethod = Console.ReadLine();
            Console.Write("Enter second number");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            string template = $"{firstNum} {userMethod} {secondNum} = ";

            switch (userMethod)
            {
                case "+" : 
                    Console.WriteLine($"{template} {firstNum+secondNum} ");
                    break;
                case "-" : 
                    Console.WriteLine($"{template} {firstNum-secondNum} ");
                    break;
                case "*" : 
                    Console.WriteLine($"{template} {firstNum*secondNum} ");
                    break;
                case "/" : 
                    Console.WriteLine($"{template} {firstNum/secondNum} ");
                    break;
                case "%" : 
                    Console.WriteLine($"{template} {firstNum%secondNum} ");
                    break;
                default:
                    Console.WriteLine("Sorry but we dont have this arithmetical method :(");
                    break;
            }

        }


    }
}
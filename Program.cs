using System;
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
           
           Console.WriteLine("Welcom to the fight club");
           Console.Write("Pleas enter your name: ");
           string userName = Console.ReadLine();
           Console.Write("Pleas enter your second name: ");
           string userLname = Console.ReadLine();
            Console.Write("Pleas enter your age: ");
           int userAge = Convert.ToInt32(Console.ReadLine());

           string  fullName = $"{userName} {userLname} and your age is {userAge}";
           if (userAge >= 18)
           {

            Console.WriteLine($"Welcom to the fight club {fullName}");
            Console.Write("Do you want to now abote rules of fight club yes/no ?: ");
            string usersAnswer = Console.ReadLine();
            switch (usersAnswer)
            {
                case "yes":
                    Console.WriteLine("The first ruel of fight club, You do not talk about");
                    Console.WriteLine("The second ruel of fight club, You DO NOT talk about FIGHT CLUB");
                    Console.WriteLine("The third ruel of fight club, If someone says 'STOP' or goes limp, taps out the fight is over");
                    Console.WriteLine("The fourth ruel of fight club,  Only two guys to a fight");
                break;

                case "no":
                    Console.WriteLine("How you gonna bee a membor of fight club without knowing about rules you mother facker, go fack out form here");
                break;

                default :
                    Console.WriteLine("Nigga we have only 2 options yes/no, you got it?");
                break;
            }
           }
           else 
           {
            Console.WriteLine("Bro sorry but your age is not enaough");
           }
           

           

        }
    }
}
using System;
using System.Reflection.Metadata;
using System.Threading;

namespace NumberGuessingGame
{
    class Program
    {
        private static string favNumber;

        static void Main(string[] args)
        {
            var r = new Random();
            {   
                var favNumber = r.Next(1, 1000);
                Console.WriteLine("Guess the number I'm thinking of between 1 and 1,000:");
                var userInput = int.Parse(Console.ReadLine());
              
        
                {
                  while (userInput != favNumber)
                   {
                        if (userInput < favNumber)
                        {
                            Console.WriteLine("Sorry, the number I am thinking of is higher than " + userInput + " Try and guess again!");
                            Console.WriteLine("Guess Again:");
                            userInput = int.Parse(Console.ReadLine());
                        }
                        else if (userInput > favNumber)
                        {
                            Console.WriteLine("Sorry, the number I am thinking of is lower than " + userInput + " Try and guess again!");
                            Console.WriteLine("Guess Again:");
                            userInput = int.Parse(Console.ReadLine());
                        }
                        else
                            Console.WriteLine("Congrats, " + favNumber + " is correct!");

                    }
                }
                
                    
                
            }   



        }
    }
}

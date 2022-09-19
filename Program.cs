using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Magic8Ball_Test
{
    class Program
    {
        /// <summary>
        /// Magic8Ball entry point, By: BC Hatfield (I created this program by following a tutorial from Jerry AKA barnacules on youtube)
        /// barnacules is the main source of this code
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Preserve Default Console Color
            ConsoleColor oldColor = Console.ForegroundColor;

            ProgramCreator();

            // Randomizer Object
            Random randomObject = new Random();

            // Loop, will run forever
            while (true)
            {

                string questionString = GetQuestionFromUser();

                // See if user actually typed a question
                if (questionString.Length == 0)
                {
                    Console.WriteLine("YOU NEED TO TYPE A QUESTION, NOT JUST HIT ENTER, DUH!");
                    continue;
                }

                // See if user wants to exit
                if (questionString.ToLower() == "quit")
                {
                    break;
                }
                if (questionString.ToLower() == "exit")
                {
                    break;
                }

                int numberOfSecondsToSleep = randomObject.Next(3) + 1;
                Console.WriteLine("Thinking about your answer, Standby...");
                Thread.Sleep(numberOfSecondsToSleep * 1000);

                // Get a random #
                int randomNumber = randomObject.Next(4);

                // Use random number to determine response
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("YES!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("NO!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("I Think Not My Friend");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Maybe Tomorrow");
                            break;
                        }

                }
            }// End of the while loop


            // Cleaning Up
            Console.ForegroundColor = oldColor;
        }

        /// <summary>
        /// This will tell the program creator's info
        /// </summary>
        static void ProgramCreator()
        {
            // Change Console Colors and print creator info
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Magic8Ball        (By: BC Hatfield)");
            Console.WriteLine("If you want to leave type quit or exit");
        }

        /// <summary>
        /// This function will return the text the user types
        /// </summary>
        /// <returns></returns>
        static string GetQuestionFromUser()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("What is your question?:");
            Console.ForegroundColor = ConsoleColor.Gray;
            string questionString = Console.ReadLine();

            return questionString;
        }

    }
}

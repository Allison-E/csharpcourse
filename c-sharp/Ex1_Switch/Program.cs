using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the letter grade recieved? (A, B, C, D, F)");

            string input = Console.ReadLine();
                
            char mark = input[0];
            
            /*if ((input != 'A') || (input != 'B') || (input != 'C') || (input != 'D') || (input != 'F'))
            {
                Environment.Exit(1);
            }*/
            switch (mark)
            {
                case 'A':
                    Console.WriteLine("You have scored between 70 and 100. \n");
                    break;
                case 'B':
                    Console.WriteLine("You have scored between 60 and 69. \n");
                    break;
                case 'C':
                    Console.WriteLine("You have scored between 50 and 59. \n");
                    break;
                case 'D':
                    Console.WriteLine("You have scored between 40 and 49. \n");
                    break;
                default:
                    Console.WriteLine("You scored less than 40. \n");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using Pong;

namespace MainProgram
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive number and we return:\n Returns 'ping' if it can be divided by 3,\n Returns 'pong' if it can be divided by 5,\n Returns 'ping-pong' if it can be divied by 3 and 5.\n Returns the number if the number doesn't meet these conditions.\n");
            StartPingPong();
        }

        private static void StartPingPong()
        {
            Console.Write("Please enter a positive number: ");
            int userInput;
            bool success = Int32.TryParse(Console.ReadLine(), out userInput);
            if(!success || userInput <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input");
                Console.ResetColor();
                StartPingPong();
            }
            else
            {
                List<string> result = PingPong.IsPingPong(userInput);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(string.Join(", ", result));
                Console.ResetColor();
            }
        }
    }
}
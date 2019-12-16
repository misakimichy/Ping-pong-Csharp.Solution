using System;
using System.Collections.Generic;
using Pong;

namespace MainProgram
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a number.");
            int inputNumber = int.Parse(Console.ReadLine());
            PingPong userPong = new PingPong();
            List<string> result = userPong.IsPingPong(inputNumber);
            foreach(string current in result)
            {
                Console.WriteLine(current);
            }
        }
    }
}
using System;

class PingPong
{
    static void Main()
    {
        Console.WriteLine("Please enter a number.");
        string userInput = Console.ReadLine();
        int inputNumber = int.Parse(userInput);

        for (int i = 1; i < inputNumber; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("ping-pong");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("pong");
            }
            else if (i % 3 == 0 )
            {
                Console.WriteLine("ping");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
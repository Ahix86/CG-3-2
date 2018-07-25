using System;

namespace CG_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,Let's play a game!");
            Console.Write("Pick a number between 1 and 10:  ");
            String userValue = Console.ReadLine();

            String message = (userValue == "8") ? "You Win!" : "You Lose!";
            
            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}

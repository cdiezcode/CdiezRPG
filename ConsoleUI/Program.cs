using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CdiezRPG!");
            Console.WriteLine("1. New Game\n2. Load Game\n3. Exit");
            Console.Write("Choose what do you want to do(enter the number): ");
            string answer = Console.ReadLine();
            int menuPoint = default;
            while (!int.TryParse(answer, out menuPoint) || (menuPoint > 3 || menuPoint < 1))
            {
                Console.WriteLine("Your choice is incorrect. Please choose valid menu point");
                Console.Write("Choose what do you want to do(enter the number): ");
                answer = Console.ReadLine();
            }

            switch (menuPoint)
            {
                case 1:
                case 2:
                    Console.WriteLine("Stubby....New Game and Load Game are not ready yet!");
                    break;
                case 3:
                    Console.WriteLine("Exiting app through menu");
                    break;
            }
        }
    }
}
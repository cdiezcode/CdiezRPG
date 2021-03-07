using System;

namespace ConsoleUI
{
    public class MainMenu
    {
        internal static void StartGame()
        {
            Console.WriteLine("Welcome to CdiezRPG!");
            Console.WriteLine("1. New Game\n2. Load Game\n3. Exit");
            Console.Write("Choose what do you want to do(enter the number): ");
            int answer = GetUserInput();

            switch (answer)
            {
                case 1:
                    StartNewGame();
                    break;
                case 2:
                    LoadGame();
                    break;
                case 3:
                    Console.WriteLine("Exiting app through menu");
                    break;
            }
        }

        private static void LoadGame()
        {
            Console.WriteLine("Loading Game.....");
        }

        private static void StartNewGame()
        {
            Console.WriteLine("Starting New Game.....");
        }

        private static bool ValidateInput(string answer, out int menuPoint)
        {
            menuPoint = default;
            return int.TryParse(answer, out menuPoint) && (menuPoint < 4 && menuPoint > 0);
        }

        private static int GetUserInput()
        {
            string answer = Console.ReadLine();
            int menuPoint = default;
            while (!ValidateInput(answer, out menuPoint))
            {
                Console.WriteLine("Your choice is incorrect. Please choose valid menu point");
                Console.Write("Choose what do you want to do(enter the number): ");
                answer = Console.ReadLine();
            }

            return menuPoint;
        } 
    }
}
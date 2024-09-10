using System;

namespace TaskMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;

            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Task One");
            Console.WriteLine("2. Task Three");
            Console.WriteLine("3. Task Four");
            Console.WriteLine("4. Task Five");
            Console.WriteLine("5. Exit");
            Console.Write("\nSelect an option: ");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    taskone taskone = new taskone();
                    break;
                case "2":
                    taskthree taskthree = new taskthree();
                    break;
                case "3":
                    taskfour taskfour = new taskfour();
                    break;
                case "4":
                    taskfive taskfive = new taskfive();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    Console.ReadKey();
                    return true;
            }
            return false;   
        }

        private static void Option1()
        {
            Console.WriteLine("You selected Option 1.");
            // Add your logic for Option 1 here.
            Console.ReadKey();
        }

        private static void Option2()
        {
            Console.WriteLine("You selected Option 2.");
            // Add your logic for Option 2 here.
            Console.ReadKey();
        }

        private static void Option3()
        {
            Console.WriteLine("You selected Option 3.");
            // Add your logic for Option 3 here.
            Console.ReadKey();
        }

        private static void Exit()
        {
            Console.WriteLine("Exiting the program...");
            Console.ReadKey();
        }
    }
}

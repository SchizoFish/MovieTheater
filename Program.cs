using System;

namespace MovieTheater
{
    class Program
    {
        // nödvändigt
        public static Tools tool = new Tools();
        public static Functions function = new Functions();
        public static bool show = true;

        static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            while(show)
            {
                Console.WriteLine();
                tool.PrintMessage("Huvudmeny\n");
                tool.PrintMessage("Välj med siffror vad du vill göra i menyn nedan\n\n");
                tool.PrintMessage("0. Avsluta");
                tool.PrintMessage("1. Bio meny");
                tool.PrintMessage("2. Scream into the void");
                tool.PrintMessage("3. Hitta det tredje ordet");
                UserInput();

            } 
        }

        // meny för bio-funktioner
        private static void TheaterMenu()
        {
            bool firstTime = true;

            while (show)
            {
                if (firstTime)
                {
                    Console.WriteLine();
                    tool.PrintMessage("Välkommen till Biostaden!");
                    firstTime = false;
                }

                Console.WriteLine();
                tool.PrintMessage("Välj med siffror vad du vill göra i menyn nedan\n");
                tool.PrintMessage("1. Se biljettpris");
                tool.PrintMessage("2. Se grupp-pris\n");
                tool.PrintMessage("x. Tillbaka till huvudmenyn");
                MovieUserInput();

            }
        }

        // metoder som läser av användarens input
        private static void UserInput()
        {
            ConsoleKeyInfo input = Console.ReadKey(true);

            switch (input.Key)
            {
                case ConsoleKey.NumPad0:
                    show = false;
                    Console.Clear();
                    break;
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    TheaterMenu();
                    break;
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    function.TenTimes();
                    break;
                case ConsoleKey.NumPad3:
                    Console.Clear();
                    function.ThirdWord();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine();
                    tool.PrintMessage("Ogiltig inmatning");
                    break;
            }
        }

        private static void MovieUserInput()
        {
            ConsoleKeyInfo input = Console.ReadKey(true);

            switch (input.Key)
            {
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    Console.WriteLine();
                    tool.PrintMessage(function.CalculatePrice());
                    break;
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    tool.PrintMessage(function.CalculateGroupPrice());
                    break;
                case ConsoleKey.X:
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine();
                    tool.PrintMessage("Ogiltig inmatning");
                    break;
            }
        }
    }
}

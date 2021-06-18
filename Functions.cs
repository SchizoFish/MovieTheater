using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater
{
    class Functions
    {
        Tools tools = new Tools();
        // enum för biljettpriser
        enum Price { Young = 80, Pension = 90, Standard = 120 }

        // tar in ålder och returnerar ett meddelande med biljettpris
        public string CalculatePrice()
        {
            tools.PrintMessageLine("Vänligen ange din ålder: ");
            int input;

            try
            {
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        return ("Felaktig inmatning\n\n");
                    }
                    else
                    {
                        if (input < 20)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            return ($"Ungomspris: {(int)Price.Young} kr\n\n");
                        }
                        else if (input > 64)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            return ($"Pensionärspris: {(int)Price.Pension} kr\n\n");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine();
                            return ($"Standardpris: {(int)Price.Standard} kr\n\n");
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    return ("Felaktig inmatning");
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine();
                return ($"ERROR: {e.Message}");
            }
        }

        // tar in antal och ålder, beräknar och returnerar grupp-pris
        public string CalculateGroupPrice()
        {
            Console.WriteLine();
            tools.PrintMessageLine("Hur många är ni i sällskapet? ");

            int groupSize = Int32.Parse(Console.ReadLine());
            int sum = 0;

            if (groupSize <= 1)
            {
                Console.Clear();
                Console.WriteLine();
                return ("Sällskap måste vara större än 1 person");
            }
            else
            {
                for (int i = 0, n = 1; i < groupSize; i++)
                {
                    Console.Clear();
                    Console.WriteLine();
                    tools.PrintMessageLine($"Vänligen ange ålder för person {n}: ");
                    int age = Int32.Parse(Console.ReadLine());

                    if (age < 20)
                    {
                        sum += (int)Price.Young;
                    }
                    else if (age > 64)
                    {
                        sum += (int)Price.Pension;
                    }
                    else
                    {
                        sum += (int)Price.Standard;
                    }

                    n++;
                }

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                return ($"För ert sällskap på {groupSize} personer blir priset: {sum} kr");
            }
        }

        // tar in en sträng från användaren och skriver ut den 10 ggr
        public void TenTimes()
        {
            bool firstScream = true;

            Console.WriteLine();
            tools.PrintMessage("SCREAM INTO THE VOID\n");

            tools.PrintMessageLine("Ange vad du vill skrika 10 gånger: ");
            string input = Console.ReadLine().ToString();
            Console.Clear();

            for (int i = 0; i < 9; i++)
            {
                if (firstScream)
                {
                    Console.WriteLine();
                    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) - ((input.Length * 10) / 2)) + "}", input + " "));
                    firstScream = false;
                }

                Console.Write(input + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        // tar in en sträng från användaren och skriver ut det tredje ordet
        public void ThirdWord()
        {
            Console.WriteLine();
            tools.PrintMessageLine("Skriv en mening på minst tre ord: ");

            var input = Console.ReadLine();

            string[] inputArr = input.Split(' ');

            // säkerställer att minst tre ord har angivits
            if (inputArr.Length < 3)
            {
                Console.Clear();
                Console.WriteLine();
                tools.PrintMessage("ERROR: Du måste skriva minst 3 ord\n");
                ThirdWord();
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                tools.PrintMessage($"Tredje ordet: {inputArr[2]}\n\n");
            }
        }
    }
}

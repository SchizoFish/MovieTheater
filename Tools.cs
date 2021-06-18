using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater
{
    class Tools
    {
        // metoder som skriver ut texten centrerat
        public void PrintMessage(string message)
        {
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (message.Length / 2)) + "}", message));
        }

        public void PrintMessageLine(string message)
        {
            Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (message.Length / 2)) + "}", message));
        }
    }
}

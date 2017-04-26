using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {

            bool AskToContinue = false;

            do
            {
                string input;

                Console.WriteLine("Please choose an option 1-Add a country,  2-See list of countries,  or 3-Exit");
                input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("Please input a country");
                    string choice = Console.ReadLine();
                    CountriesTextFile.WriteToFile(choice);
                    Console.WriteLine("Your country has been saved!");

                }
                else if (input == "2")
                {
                    CountriesTextFile.ReadFromFile();

                }

                else
                {
                    Console.WriteLine("Thanks for trying!");
                    break;

                }
                string continueinput;
                Console.WriteLine("Would you like to try again?");
                continueinput = Console.ReadLine().ToUpper();
                if (continueinput == "Y")
                {
                    AskToContinue = true;
                }
                else
                {
                    Console.WriteLine("thanks for trying!");
                    return;
                }
            } while (AskToContinue);

        }
    }
}

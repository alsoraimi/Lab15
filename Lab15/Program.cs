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
            Console.WriteLine("Welcome to the Countries Maintenance Application!");
            Console.WriteLine();

            bool AskToContinue = false;         // loop to ask user to continue or not

            do
            {

               string input = ValidateInput.ValidInput();
                if (input == "1")
                {
                    Console.WriteLine("Please input a country");
                    string choice = Console.ReadLine();                 // get user input
                    CountriesTextFile.WriteToFile(choice);
                    Console.WriteLine("Your country has been saved!");
                }
                else if (input == "2")
                {
                    Console.WriteLine();
                    CountriesTextFile.ReadFromFile();    //lists countries from text file
                }

                else
                {
                    Console.WriteLine("Thanks for trying!");  //if user selects exit
                    break;
                }

                Console.WriteLine();

                string continueinput;
                Console.WriteLine("Would you like to try again?");
                continueinput = ValidateInput.ValidContinueInput();
                if (continueinput == "Y")
                {
                    AskToContinue = true;
                    Console.Clear();
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

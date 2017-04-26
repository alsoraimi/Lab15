using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class ValidateInput
    {
        public static string ValidInput()
        {

            Console.WriteLine("Please choose an option 1-Add a country,  2-See list of countries,  or 3-Exit");  //prompts user to enter an input
           string input = Console.ReadLine();
            while (true)
            {

                if (input != "1" && input != "2" && input != "3")
                {
                    Console.WriteLine("ERROR, PLEASE ENTER 1, 2, OR 3"); // validation for user input
                    input = Console.ReadLine();
                    continue;

                }
                break;

            }return input;
        }

        public static string ValidContinueInput()

        {
            string input = Console.ReadLine().ToUpper();
            while (true)
                {
                if (input != "Y" && input != "N")
                {
                    Console.WriteLine("ERROR, PLEASE ENTER Y OR N");     //added validation for user input if they want to continue or not, only accepts Y or N
                    input = Console.ReadLine().ToUpper();
                    continue;

                }break;

            }return input;
        }
    }
}

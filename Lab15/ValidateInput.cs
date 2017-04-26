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

            Console.WriteLine("Please choose an option 1-Add a country,  2-See list of countries,  or 3-Exit");
           string input = Console.ReadLine();
            while (true)
            {

                if (input != "1" && input != "2" && input != "3")
                {
                    Console.WriteLine("ERROR, PLEASE ENTER 1, 2, OR 3");
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
                    Console.WriteLine("ERROR, PLEASE ENTER Y OR N");
                    input = Console.ReadLine().ToUpper();
                    continue;

                }break;

            }return input;
        }
    }
}

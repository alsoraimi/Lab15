using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    class CountriesTextFile
    {
        public static void WriteToFile(string input)
        {
            StreamWriter sw = new StreamWriter("../../Countries.txt", true);  //the ..//..// tells it to go two levels up


            sw.WriteLine(input); // gets user input on which country to add to text file

            sw.Close();
        }

        public static string ReadFromFile()
        {
            StreamReader rd = new StreamReader("../../Countries.txt");

            string FileContent = rd.ReadToEnd();  //read to end reads the whole file

            Console.WriteLine(FileContent);   // lists all countries added to text file on console
            rd.Close();
            return FileContent;
        }




    }
}

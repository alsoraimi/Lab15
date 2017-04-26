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


            sw.WriteLine(input);

            sw.Close();
        }

        public static string ReadFromFile()
        {
            StreamReader rd = new StreamReader("../../Countries.txt");

            string FileContent = rd.ReadToEnd();  //read to end reads the whole file

            Console.WriteLine(FileContent);
            rd.Close();
            return FileContent;
        }

    }
}

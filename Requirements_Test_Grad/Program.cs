using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirements_Test_Grad
{
    /// <summary>
    /// Contains the Main method of the application.
    /// Provides method to return input file name without ".txt" extension.
    /// </summary>
    class Program
    {
        private static String inputFile;
        private static String shortenedInputFile;
        public static InputFile file = new InputFile();

        static void Main(string[] args)
        {
            Console.Write("grade-scores ");
            // get input file name
            inputFile = Console.ReadLine();
            // create shortened file name
            shortenedInputFile = inputFile;
            // create array holding input file data
            String[] inputFileContents = System.IO.File.ReadAllLines(inputFile);
            // sort array
            List<Person> personList = new List<Person>();
            personList = file.SortFile(inputFileContents);
            file.PrintSortedList(personList);
            file.SaveSortedList(list: personList);
            Console.ReadKey();
        }

        public String GetShortenedInputFile()
        {
            shortenedInputFile = shortenedInputFile.Remove(shortenedInputFile.Length - 4);
            return shortenedInputFile;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirements_Test_Grad
{
    /// <summary>
    /// Provides methods to sort an input .txt file, print a sorted
    /// file to the console, and save a sorted file to a new .txt file.
    /// </summary>
    public class InputFile
    {
        public List<Person> SortFile(String[] file)
        {
            string[] seperators = { ",", " " };
            // list which holds person objects created from input file
            List<Person> personList = new List<Person>();
            // list which holds sorted person objects 
            List<Person> sortedPersonList = new List<Person>();

            foreach (String line in file)
            {
                if (!String.IsNullOrEmpty(line))
                {
                    // create individual person objects and add to unsorted list
                    String[] PersonString = line.Split(seperators, StringSplitOptions.
                        RemoveEmptyEntries);
                    Person person = new Person(PersonString[0], PersonString[1],
                        int.Parse(PersonString[2]));
                    personList.Add(person);
                }
            }

            // sort person objects by score, last name, and first name
            sortedPersonList = personList.OrderByDescending(Person => Person.GetScore())
            .ThenBy(Person => Person.GetLastName()).ThenBy(Person => Person.GetFirstName())
            .ToList();
            // return a sorted list
            return sortedPersonList;
        }

        public void PrintSortedList(List<Person> list)
        {
            Console.WriteLine("\r");
            foreach (Person person in list)
            {
                Console.WriteLine(person.PersonToString() + "\n");
            }
        }

        public void SaveSortedList(List<Person> list)
        {
            Program program = new Program();
            // original input file name without ".txt" extension
            String saveFile = program.GetShortenedInputFile();

            using (System.IO.TextWriter gradedText = new System.IO.StreamWriter
                (path: saveFile + "-graded.txt"))
            {
                foreach (Person person in list)
                {
                    gradedText.WriteLine(person.PersonToString() + Environment.NewLine);
                }
            }
            Console.WriteLine("Finished: created " + saveFile + "-graded.txt");
        }
    }
}

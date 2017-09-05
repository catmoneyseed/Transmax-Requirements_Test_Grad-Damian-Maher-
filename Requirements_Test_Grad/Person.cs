using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirements_Test_Grad
{
    /// <summary>
    /// Represents a person created from each line in the .txt file.
    /// Provides methods to create a new person, and get the first name, 
    /// last name, and score of that person.
    /// </summary>
    public class Person
    {
        private String LastName;
        private String FirstName;
        private int Score;

        // create a new person object
        public Person(String Last, String First, int n)
        {
            this.LastName = Last;
            this.FirstName = First;
            Score = n;
        }

        // return the string representation of a person object
        public String PersonToString()
        {
            String PersonString;
            PersonString = GetLastName() + ", " + GetFirstName() + ", " + GetScore().ToString();
            return PersonString;
        }

        // getter methods
        public String GetLastName() => LastName;
        public String GetFirstName() => FirstName;
        public int GetScore() => Score;
    }
}

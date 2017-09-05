using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Requirements_Test_Grad;

namespace PersonTest.Test
{
    /// <summary>
    /// Provides methods to check Person constructor, 
    /// and correct retrieval of person attributes including
    /// first name, last name, and score.
    /// </summary>
    [TestClass]
    public class PersonTest
    {
        // Initialise Person
        Person testPerson = new Person("Smith", "John", 85);

        [TestMethod]
        public void Test_Person()
        {
            // Assert
            Assert.IsNotNull(testPerson);
        }

        [TestMethod]
        public void Test_PersonString()
        {
            // Arrange
            String expected = "Smith, John, 85";
            // Act
            String actual = testPerson.PersonToString();
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetPersonLastName()
        {
            // Arrange
            String expected = "Smith";
            // Act
            String actual = testPerson.GetLastName();
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetPersonFirstName()
        {
            // Arrange
            String expected = "John";
            // Act
            String actual = testPerson.GetFirstName();
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetPersonScore()
        {
            // Arrange
            int expected = 85;
            // Act
            int actual = testPerson.GetScore();
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

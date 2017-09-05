using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Requirements_Test_Grad;
using System.Collections.Generic;
using System.Diagnostics;

namespace FileTest.Test
{
    [TestClass]
    public class FileTest
    {
        [TestMethod]
        public void Test_SortFile()
        {
            // Arrange
            InputFile file = new InputFile();
            List<Person> expectedSorted = new List<Person>();
            expectedSorted.Add(new Person("BUNDY", "TERESSA", 88));
            expectedSorted.Add(new Person("KING", "MADISON", 88));
            expectedSorted.Add(new Person("SMITH", "FRANCIS", 85));
            expectedSorted.Add(new Person("SMITH", "ALLAN", 70));

            String[] unsorted = new String[4];
            unsorted[0] = "BUNDY, TERESSA, 88";
            unsorted[1] = "SMITH, ALLAN, 70";
            unsorted[2] = "KING, MADISON, 88";
            unsorted[3] = "SMITH, FRANCIS, 85"; 

            List<Person> sorted = new List<Person>();

            // Act
            sorted = file.SortFile(unsorted);
            for(int i = 0; i < expectedSorted.Count; i++)
            {
                Assert.AreEqual(expectedSorted[i].PersonToString(), sorted[i].PersonToString());
            }
        }

    }
}

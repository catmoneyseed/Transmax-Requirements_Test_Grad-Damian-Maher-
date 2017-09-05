using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Program.Test
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void Test_ShortenedInputFile()
        {
            // Arrange
            String input = "scoresList.txt";
            String expected = "scoresList";
        }
    }
}

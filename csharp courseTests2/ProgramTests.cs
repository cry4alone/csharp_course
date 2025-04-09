using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_course.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [DataTestMethod]
        [DataRow(567, 7, 6)]
        [DataRow(45, 5, 4)]
        public void GetNums_ParameterizedTest(int input, int expectedOnes, int expectedTens)
        {
            int[] result = Program.GetNums(input);

            Assert.AreEqual(expectedOnes, result[0]);
            Assert.AreEqual(expectedTens, result[1]);
        }
    }
}
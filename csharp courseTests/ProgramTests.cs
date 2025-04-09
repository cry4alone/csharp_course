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
        [TestMethod()]
        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(5.5f, 1)]
        [DataRow(-3.14f, -1)]
        public void Sign_ParameterizedTest(float input, int expected)
        {
            int result = Program.Sign(input);
            Assert.AreEqual(expected, result);
        }   
    }
}
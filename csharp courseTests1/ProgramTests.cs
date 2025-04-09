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
        [DataRow(10, 40)]
        [DataRow(5, 20)]
        public void PerimeterTest(float input, float expected)
        {
            float result = Program.Perimeter(input);
            Assert.AreEqual(expected, result);
        }
    }
}
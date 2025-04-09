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
        [DataTestMethod()]
        [DataRow(0, 5, 2, 0)]
        [DataRow(3, 5, 2, 2)]
        public void getMinTest(int inputA, int inputB, int inputC, int expected)
        {
            int result = Program.getMin(inputA, inputB, inputC);
            Assert.AreEqual(expected, result);
        }
    }
}
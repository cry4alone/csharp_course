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
        [DataRow(1, "Понедельник")]
        [DataRow(2, "Вторник")]
        [DataRow(3, "Среда")]
        [DataRow(4, "Четверг")]
        [DataRow(5, "Пятница")]
        [DataRow(6, "Суббота")]
        [DataRow(7, "Воскресенье")]

        public void GetWeekdayTest(int input, string expected)
        {
            string result = Program.GetWeekday(input);
            Assert.AreEqual(expected, result);
        }
    }
}
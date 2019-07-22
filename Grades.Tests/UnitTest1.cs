using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90f);
            book.AddGrade(50f);
            book.AddGrade(100f);

            GradeStatistics stats = book.ComputeStatistics();
            Assert.AreEqual(100f, stats.highestGrade);
        }

        public
    }
}
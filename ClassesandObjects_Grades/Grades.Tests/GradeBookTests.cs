using _2ClassesandObjects_Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grades.Tests
{
  [TestClass]
  public class GradeBookTests
  {
    [TestMethod]
    public void ComputesHighestGrade()
    {
      GradeBook book = new GradeBook();
      book.AddGrade(10);
      book.AddGrade(90);

      GradeStatistics stats = book.ComputeStatistics();
      Assert.AreEqual(90, stats.HighestGrade);
    }

    [TestMethod]
    public void ComputesLowestGrade()
    {
      GradeBook book = new GradeBook();
      book.AddGrade(10);
      book.AddGrade(90);

      GradeStatistics stats = book.ComputeStatistics();
      Assert.AreEqual(10, stats.LowestGrade);
    }

    [TestMethod]
    public void ComputesAverageGrade()
    {
      GradeBook book = new GradeBook();
      book.AddGrade(91);
      book.AddGrade(89.5f);
      book.AddGrade(75);

      GradeStatistics stats = book.ComputeStatistics();
      Assert.AreEqual(85.16, stats.AverageGrade, 0.01);
    }

    [TestMethod]
    public void StringComparisons()
    {
      string name1 = "Scott";
      string name2 = "scott";

      bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void ReferenceTypesPassByValue()
    {
      GradeBook book1 = new GradeBook();
      GradeBook book2 = book1;

      GiveBookAName(book2);
      Assert.AreEqual("A GradeBook", book1.Name);
    }

    private void GiveBookAName(GradeBook book)
    {
      book.Name = "A GradeBook";
    }

    [TestMethod]
    public void ValueTypesPassByValue()
    {
      int x = 46;
      IncreMentNumber(x);

      Assert.AreEqual(46, x);
    }

    private void IncreMentNumber(int number)
    {
      number += 1;
    }
  }
}
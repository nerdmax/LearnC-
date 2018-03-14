using System;

namespace _2ClassesandObjects_Grades
{
  public class ThrowAwayGradeBook : GradeBook
  {
    public override GradeStatistics ComputeStatistics()
    {
      float lowest = float.MaxValue;
      foreach (float grade in this.grades)
      {
        lowest = Math.Min(grade, lowest);
      }
      this.grades.Remove(lowest);
      return base.ComputeStatistics();
    }
  }
}
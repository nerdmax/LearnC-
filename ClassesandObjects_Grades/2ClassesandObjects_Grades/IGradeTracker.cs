namespace _2ClassesandObjects_Grades
{
  using System.Collections;
  using System.IO;

  internal interface IGradeTracker : IEnumerable
  {
    void AddGrade(float grade);

    GradeStatistics ComputeStatistics();

    void WriteGrades(TextWriter destination);

    string Name { get; set; }
  }
}
using System;
using System.Collections.Generic;
using System.IO;

namespace _2ClassesandObjects_Grades
{
  using System.Collections;

  public class GradeBook : GradeTracker
  {
    public GradeBook()
    {
      //_name = "Empty";

      grades = new List<float>();
    }

    public override void AddGrade(float grade)
    {
      grades.Add(grade);
    }

    public override GradeStatistics ComputeStatistics()
    {
      GradeStatistics stats = new GradeStatistics();

      float sum = 0;
      foreach (float grade in grades)
      {
        sum += grade;

        stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
        stats.HighestGrade = Math.Max(grade, stats.LowestGrade);
      }
      stats.AverageGrade = sum / grades.Count;

      return stats;
    }

    public override void WriteGrades(TextWriter destination)
    {
      for (int i = 0; i < this.grades.Count; i++)
      {
        destination.WriteLine(this.grades[i]);
      }
    }

    public override IEnumerator GetEnumerator()
    {
      return this.grades.GetEnumerator();
    }

    protected List<float> grades;

    public string Name
    {
      get { return _name; }
      set
      {
        if (string.IsNullOrEmpty(value))
        {
          throw new ArgumentException("Custom error message from Max's program");
        }

        if (_name != value)
        {
          NameChangedEventArgs args = new NameChangedEventArgs();
          args.ExistingName = _name;
          args.NewName = value;
          NameChanged(this, args);
        }
        _name = value;
      }
    }

    private string _name;

    public event NameChangedDelegate NameChanged;
  }
}
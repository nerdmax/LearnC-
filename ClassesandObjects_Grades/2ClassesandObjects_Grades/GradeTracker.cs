using System;

namespace _2ClassesandObjects_Grades
{
  using System.Collections;
  using System.IO;

  public abstract class GradeTracker : IGradeTracker
  {
    public abstract void AddGrade(float grade);

    public abstract GradeStatistics ComputeStatistics();

    public abstract void WriteGrades(TextWriter destination);

    public abstract IEnumerator GetEnumerator();

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

    protected string _name;

    public event NameChangedDelegate NameChanged;
  }
}
using System;
using System.IO;

namespace _2ClassesandObjects_Grades
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      IGradeTracker book = new ThrowAwayGradeBook();

      SetBookChangedEvent(book);
      GetBookName(book);
      AddGrades(book);
      SaveGradesToFile(book);
      WriteResultsToConsole(book);
    }

    private static void WriteResultsToConsole(IGradeTracker book)
    {
      GradeStatistics stats = book.ComputeStatistics();
      foreach (float grade in book)
      {
        Console.WriteLine(grade);
      }
      WriteResult("Average", stats.AverageGrade);
      WriteResult("Highest", (int)stats.HighestGrade);
      WriteResult("Lowest", stats.LowestGrade);
    }

    private static void SaveGradesToFile(IGradeTracker book)
    {
      using (StreamWriter outputFile = File.CreateText("grades.txt"))
      {
        book.WriteGrades(outputFile);
      }
    }

    private static void AddGrades(IGradeTracker book)
    {
      book.AddGrade(50);
      book.AddGrade(50);
      book.AddGrade(100);
      book.AddGrade(100);
    }

    private static void SetBookChangedEvent(IGradeTracker book)
    {
      //book.NameChanged += new NameChangedDelegate(OnNameChanged);
      //book.NameChanged += new NameChangedDelegate(OnNameChanged2);
      //book.NameChanged += OnNameChanged2;
      //book.NameChanged -= OnNameChanged2;
    }

    private static void GetBookName(IGradeTracker book)
    {
      try
      {
        Console.WriteLine("Enter a name");
        //book.Name = Console.ReadLine();
        book.Name = null;
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine(ex.Message);
      }
      catch (Exception)
      {
        Console.WriteLine("Something went wrong!");
      }

      //book.Name = "Max's book";
      //book.Name = "YOYO's book";
      //book.Name = null;
    }

    private static void WriteResult(string description, float result)
    {
      Console.WriteLine("{0}: {1:F2}", description, result);
    }

    private static void WriteResult(string description, int result)
    {
      Console.WriteLine("{0}: {1}", description, result);
    }

    private static void OnNameChanged(object sender, NameChangedEventArgs args)
    {
      Console.WriteLine("Name changed from {0} to {1}", args.ExistingName, args.NewName);
    }

    private static void OnNameChanged2(object sender, NameChangedEventArgs args)
    {
      Console.WriteLine("@@@");
    }
  }
}
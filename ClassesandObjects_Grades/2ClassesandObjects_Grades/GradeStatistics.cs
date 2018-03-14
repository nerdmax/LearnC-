namespace _2ClassesandObjects_Grades
{
  public class GradeStatistics
  {
    public GradeStatistics()
    {
      AverageGrade = 0;
      LowestGrade = float.MaxValue;
      HighestGrade = float.MinValue;
    }

    public float AverageGrade;
    public float LowestGrade;
    public float HighestGrade;
  }
}
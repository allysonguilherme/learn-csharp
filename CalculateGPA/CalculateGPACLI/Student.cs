namespace CalculateGPACLI;

public class Student
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; }

    public int GetScoresSum()
    {
        int sum = 0;
        Courses.ForEach(c => sum += c.getCourseScore());

        return sum;
    }

    public int GetTotalCreditHours()
    {
        int sum = 0;
        Courses.ForEach(c => sum += c.CreditHours);

        return sum;
    }

    public void PrintCourses()
    {
        Console.WriteLine("Course".FormatString(25) + "Grade".FormatString(25) + "Credit Hours");
        Courses.ForEach(c => Console.WriteLine($"{c.Name.FormatString(25)}{c.Grade.ToString().FormatString(25)}{c.CreditHours}"));
    }

    public void PrintFinalGpa()
    {
        decimal gradePointAverage = (decimal)GetScoresSum() / GetTotalCreditHours();

        int firstDigit = (int)gradePointAverage;
        
        int secondPart = (int) ((gradePointAverage - firstDigit) * 100);

        decimal finalNumber = firstDigit + (decimal)secondPart / 100;

        Console.WriteLine("\n" + "Final GPA:".FormatString(25) + finalNumber.ToString().FormatString(25));
    }
}
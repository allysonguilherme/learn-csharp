using System.Reflection.Metadata.Ecma335;

namespace CalculateGPACLI;

public class Course
{
    public string Name { get; set; }
    public int CreditHours { get; set; }
    public int Grade { get; set; }

    public int getCourseScore()
    {
        return CreditHours * Grade;
    }
}
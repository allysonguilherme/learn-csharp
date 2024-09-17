// See https://aka.ms/new-console-template for more information

using CalculateGPACLI;

Student sophia = new()
{
    Name = "Sophia Johnson",
    Courses = new List<Course>()
    {
        new ()
        {
            Name = "English 101",
            Grade = 4,
            CreditHours = 3
        },
        new ()
        {
            Name = "Algebra 101",
            Grade = 3,
            CreditHours = 3
        },
        new ()
        {
            Name = "Biology 101",
            Grade = 3,
            CreditHours = 4
        },
        new ()
        {
            Name = "Computer Science I",
            Grade = 3,
            CreditHours = 4
        },
        new ()
        {
            Name = "Psychology 101",
            Grade = 4,
            CreditHours = 3
        },
    }
};

sophia.PrintCourses();
sophia.PrintFinalGpa();
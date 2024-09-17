using System.Collections.ObjectModel;

namespace calculate_grades;

public class Aluno
{
    public string Name { get; set; }

    public List<int> Grades { get; set; }

    public Aluno(string name, List<int> grades)
    {
        Name = name;
        Grades = grades;
    }

    public decimal GetFinalScore(){
        return (decimal) Grades.Sum() / (decimal)Grades.Count();
    }

    public string GetGradingScale(){
        return GradingScale(GetFinalScore());
    }

    private string GradingScale(decimal socre){
        
        switch(socre){
            case > 96:
                return "A+";
            case > 92:
                return "A";
            case > 89:
                return "A-";
            case > 86:
                return "B+";
            case > 82:
                return "B";
            default:
                return "C";
        }
    }
}

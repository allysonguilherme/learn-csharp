using calculate_grades;

List<Aluno> alunos = new (){
    new Aluno("Sophia", new List<int>{93, 87, 98, 95, 100}),
    new Aluno("Nicolas", new List<int>{80, 83, 82, 88, 85}),
    new Aluno("Zahirah", new List<int>{84, 96, 73, 85, 79}),
    new Aluno("Jeong", new List<int>{90, 92, 98, 100, 97}),
};

System.Console.WriteLine("Students Grade \n");

alunos.ForEach(a => Console.WriteLine($"{a.Name}: {a.GetFinalScore()} {a.GetGradingScale()}"));

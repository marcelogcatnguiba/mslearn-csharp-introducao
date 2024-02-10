using MicrosoftLearn.CalculoGPA;

var cursos = new List<Curso>()
{
    new Curso{Nome= "English 101", Credito = 4, CreditoHoras = 3},
    new Curso{Nome= "Algebra 101", Credito = 3, CreditoHoras = 3},
    new Curso{Nome= "Biology 101", Credito = 3, CreditoHoras = 4},
    new Curso{Nome= "Computer Science I", Credito = 3, CreditoHoras = 4},
    new Curso{Nome= "Psychology 101", Credito = 4, CreditoHoras = 3},
};
var aluno = new Aluno("Sophia", cursos);

System.Console.WriteLine($"Aluno: {aluno.Nome}, Total Grade Points: {aluno.TotalDeGradePoints}, Total Creditos: {aluno.TotalCreditos}");
System.Console.WriteLine("Course \t\t Credito \t Credito Hour");

foreach (var c in aluno.Cursos)
    System.Console.WriteLine($"{c.Nome} \t\t {c.Credito} \t {c.CreditoHoras}");

System.Console.WriteLine($"Total GPA: {aluno.CalculoGPA().ToString("f2")}");
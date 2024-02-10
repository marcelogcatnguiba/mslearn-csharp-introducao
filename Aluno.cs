using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftLearn.CalculoGPA
{
    public class Aluno
    {
        public string Nome { get; set; } = "";
        public IEnumerable<Curso> Cursos { get; set; } = new List<Curso>();
        public int TotalCreditos { get; private set; }
        public int TotalDeGradePoints { get; private set; }

        public Aluno(string nome, IList<Curso> cursos)
        {
            Nome = nome;
            Cursos = cursos;

            CalculaCredito();
            CalcularGradePoints();

        }

        public void CalculaCredito()
        {
            foreach (var c in Cursos)
                TotalCreditos += c.Credito;
        }

        public void CalcularGradePoints()
        {
            foreach (var t in Cursos)
                TotalDeGradePoints += t.Credito * t.CreditoHoras;
        }

        public decimal CalculoGPA()
        {
            return (decimal)TotalDeGradePoints / TotalCreditos;
        }
    }
}
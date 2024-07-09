using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinocSh
{
    internal class Professores
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public char Periodo { get; set; }
        public string Materia { get; set; }
        public List<string> turmas = new List<string>();

        public void ShowProfessor()
        {
            Console.WriteLine($"Professor: {Nome};\nPeriodo: {Periodo};\nMateria: {Materia};");
            foreach (var turma in turmas) {
                Console.Write($"Turma: {turma};\n");
            } ;

        }

        public void AddTurma(string turma )
        {
            turmas.Add(turma);
        }

        

    }
}

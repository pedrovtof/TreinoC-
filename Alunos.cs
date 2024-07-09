using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinocSh
{
    internal class Alunos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public char Periodo { get; set; }
        public string Turma { get; set; }

        public void ShowAlunos() {
            Console.WriteLine($"Aluno: {Nome}; \nPeriodo: {Periodo}; \nMateria: {Turma};");
        }

    }
}

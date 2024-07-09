using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinocSh
{
    internal class Boletim
    {
        Dictionary<int, int> ProfessorAluno = new Dictionary<int, int>();
        public string Turma { get; set; }
        public char Periodo { get; set; }
        public List<double> Atividades = new List<double>();
        public List<double> Provas = new List<double>();

        public void ShowBoletim(int i)
        {
            if (Provas.Count < 1 || Atividades.Count < 1)
            {
                Console.WriteLine("Ops! Ainda não existe registro de notaas para esse boletim");
            }
            else 
            {
                Console.WriteLine($"Professor: {ProfessorAluno.Values.First()}; \nAluno: {ProfessorAluno[i]}; \nTurma: {Turma}; \nPeriodo: {Periodo};");

                int contador = 1;

                foreach (var Atividade in Atividades) {
                   
                    Console.WriteLine($"Nota atividade {contador}: {Atividade}");
                    contador ++;
                }

                contador = 1;

                foreach (var Prova in Provas)
                {

                    Console.WriteLine($"Nota prova {contador}: {Prova}");
                    contador++;
                }
            }
        }

        public void Aprovado() 
        {
            Double atividades_soma = Atividades.Sum();
            Double prova_soma = Provas.Sum();
            int quantidade_atividades = Atividades.Count();
            int quantidade_provas = Provas.Count();
            Double nota = (prova_soma / quantidade_provas) + ((atividades_soma / quantidade_atividades) / 10);
            Console.WriteLine($"Nota: {nota.ToString("F2")};");
        }

        public void AddAtividades(double var)
        {
            Atividades.Add(var);
        }

        public void AddProvas(double var)
        {
            Provas.Add(var);
        }

        public void AddProfessorAluno(int x, int y)
        {
            ProfessorAluno.Add(x, y);
        }

    }
}


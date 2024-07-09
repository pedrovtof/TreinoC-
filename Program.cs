using treinocSh;

Console.WriteLine(@"
    ╔═══╦═══╦═══╦═══╦═══╦╗──╔╦═══╦════╦═══╗
    ║╔═╗║╔══╩╗╔╗║╔═╗║╔═╗║╚╗╔╝║╔═╗║╔╗╔╗║╔══╝
    ║╚═╝║╚══╗║║║║╚═╝║║─║╠╗║║╔╣║─║╠╝║║╚╣╚══╗
    ║╔══╣╔══╝║║║║╔╗╔╣║─║║║╚╝║║║─║║─║║─║╔══╝
    ║║──║╚══╦╝╚╝║║║╚╣╚═╝║╚╗╔╝║╚═╝║─║║─║║
    ╚╝──╚═══╩═══╩╝╚═╩═══╝─╚╝─╚═══╝─╚╝─╚╝
        ");

Alunos aluno_1 = new Alunos();
Alunos aluno_2 = new Alunos();

aluno_1.Periodo = 'M';
aluno_1.Turma = "9";
aluno_1.Nome = "Pedro";
aluno_1.Id = 1;

aluno_2.Periodo = 'M';
aluno_2.Turma = "7";
aluno_2.Nome = "Alice";
aluno_2.Id = 2;

aluno_1.ShowAlunos();
aluno_2.ShowAlunos();

Professores professor_1 = new Professores();
Professores professor_2 = new Professores();

professor_1.Id = 1;
professor_1.Nome = "Serjio";
professor_1.Materia = "Matematica";
professor_1.Periodo = 'M';
professor_1.AddTurma("9");
professor_1.AddTurma("7");

professor_2.Id = 2;
professor_2.Nome = "Renata";
professor_2.Materia = "Historia";
professor_2.Periodo = 'M';
professor_2.AddTurma("9");
professor_2.AddTurma("7");

professor_1.ShowProfessor();
professor_2.ShowProfessor();

Console.WriteLine("\n\n\n");

Boletim boletim_1 = new Boletim();
boletim_1.AddProvas(9.2);
boletim_1.AddProvas(8.1);
boletim_1.AddAtividades(3.4);
boletim_1.AddAtividades(7.4);
boletim_1.AddAtividades(4);
boletim_1.AddAtividades(9.2);
boletim_1.AddProfessorAluno(1, 2);
boletim_1.Turma = "9";
boletim_1.Periodo = 'M';
boletim_1.ShowBoletim(1);
boletim_1.Aprovado();



Boletim boletim_2 = new Boletim();
boletim_2.AddAtividades(3.4);
boletim_2.AddAtividades(7.4);
boletim_2.AddAtividades(4);
boletim_2.AddAtividades(9.2);
boletim_2.AddProvas(5.1);
boletim_2.AddProvas(6.0);
boletim_2.AddProfessorAluno(1,1);
boletim_2.Turma = "9";
boletim_2.Periodo = 'M';
boletim_2.ShowBoletim(1);
boletim_2.Aprovado();

Console.Read();
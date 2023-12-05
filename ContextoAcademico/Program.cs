using static ContextoAcademico.Model;

Aluno aluno = new();
Disciplina disciplina = new();

//Cadastrando o Aluno e a Disciplina
aluno.Nome = "Maria";
disciplina.Nome = "Matemática";

// Matriculando um aluno em uma disciplina
aluno.Disciplinas.Add(disciplina);

// Associando uma disciplina a um aluno
disciplina.Alunos.Add(aluno);

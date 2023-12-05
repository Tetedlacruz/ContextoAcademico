using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextoAcademico
{
    internal class Model
    {
        //Tabela Aluno
        public class Aluno
        {
            public int AlunoId { get; set; }
            public string Nome { get; set; }
            public ICollection<Disciplina> Disciplinas { get; set; }
        }

        //Tabela Disciplina
        public class Disciplina
        {
            public int DisciplinaId { get; set; }
            public string Nome { get; set; }
            public ICollection<Aluno> Alunos { get; set; }
        }

        //Tabela de junção AlunoDisciplina
        public class AlunoDisciplina
        {
            public int AlunoId { get; set; }
            public int DisciplinaId { get; set; }
        }
    }
}

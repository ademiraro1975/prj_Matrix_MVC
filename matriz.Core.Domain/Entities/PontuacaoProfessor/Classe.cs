using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Classe
    {

        public int Id { get; private set; }
        public int Ano { get; private set; }
        public int Ciclo { get; private set; }
        public string ClasseNome { get; private set; } = string.Empty;
        public int Nivel { get; private set; }
        public int NumeroAlunos { get; private set; }
        public string Turma { get; private set; } = string.Empty;


        public int CursoUnidadeId { get; private set; }
        public int PeriodoId { get; private set; }

        public CursoUnidade CursoUnidade { get; } = new CursoUnidade();
        public Periodo Periodo { get; } = new Periodo();

        //public ICollection<AlunoClasse> AlunoClasses { get; } = new List<AlunoClasse>();
        //public ICollection<Aulas> Aulass { get; } = new List<Aulas>();
        public ICollection<ClasseGrupoDisciplina> ClasseGrupoDisciplinas { get; } = new List<ClasseGrupoDisciplina>();
        //public ICollection<Horario> Horarios { get; } = new List<Horario>();
        
        public Classe()

        {
            ClasseGrupoDisciplinas = new HashSet<ClasseGrupoDisciplina>();
            //AlunoClasses = new HashSet<AlunoClasse>();
            //Horarios = new HashSet<Horario>();
            //Aulass = new HashSet<Aulas>();
        }
    }
}

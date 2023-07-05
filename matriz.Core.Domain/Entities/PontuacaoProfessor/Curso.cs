using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Curso
{

        public int Id { get; private set; }

        public string Atribuicao { get; private set; } = string.Empty;
        public string Codigo { get; private set; } = string.Empty;
        public string Fundlegal { get; private set; } = string.Empty;
        public string Nome { get; private set; } = string.Empty;
        public string Perfilprofissional { get; private set; } = string.Empty;
        public int Quantidadeniveis { get; private set; }

        public int ModalidadeId { get; private set; }
        public int HabilitacaoId { get; private set; }
        public int PeriodoId { get; private set; }

        public  Habilitacao HabilitacaoFinal { get; } = new Habilitacao();
        public  Modalidade Modalidade { get; } = new Modalidade();
    


        public ICollection<CursoArea> CursoAreas { get; } = new List<CursoArea>();
        public ICollection<CursoDisciplina> CursoDisciplinas { get; } = new List<CursoDisciplina>();
        public ICollection<CursoHabilitacao> CursoHabilitacaos { get; } = new List<CursoHabilitacao>();
        public ICollection<CursoUnidade> CursoUnidades { get; } = new List<CursoUnidade>();

        public Curso()
        {
            CursoAreas = new HashSet<CursoArea>();
            CursoDisciplinas = new HashSet<CursoDisciplina>();
            CursoHabilitacaos = new HashSet<CursoHabilitacao>();
            CursoUnidades = new HashSet<CursoUnidade>();
        }

    }
}

using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CursoUnidade
    {

        public int Id { get; private set; }
        public bool Estagio { get; private set; } = false;
        public bool Status { get; private set; } = false;
        public bool TCC { get; private set; } = false;

        public int CursoId { get; private set; }
        public int UnidadeId { get; private set; }

        public Curso Curso { get; } = new Curso();
        public Unidade Unidade { get; } = new Unidade();


        public ICollection<Classe> Classes { get; } = new List<Classe>();
        public ICollection<CursoUnidadeFundLegal> CursoUnidadeFundLegals { get; } = new List<CursoUnidadeFundLegal>();
        public ICollection<CursoUnidadePeriodo> CursoUnidadePeriodos { get; } = new List<CursoUnidadePeriodo>();
   
        public CursoUnidade()
        {
            Classes = new HashSet<Classe>();
            CursoUnidadeFundLegals = new HashSet<CursoUnidadeFundLegal>();
            CursoUnidadePeriodos = new HashSet<CursoUnidadePeriodo>();
        }    
    
    }
}

using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class FundLegal
    {

        public int Id { get; private set; }
        public string Fundlegal { get; private set; } = string.Empty;

        public ICollection<CursoUnidadeFundLegal> CursoUnidadeFundLegals { get;} = new List<CursoUnidadeFundLegal>();
        public FundLegal()
        {
            CursoUnidadeFundLegals = new HashSet<CursoUnidadeFundLegal>();
        }   
    
    
    }
}

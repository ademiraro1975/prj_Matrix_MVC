using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class FundLegalConfigurarion
    {

        public int Id { get; private set; }
        public string Fundlegal { get; private set; } = string.Empty;

        public ICollection<CursoUnidadeFundLegalConfigurarion> CursoUnidadeFundLegals { get;} = new List<CursoUnidadeFundLegalConfigurarion>();
        public FundLegalConfigurarion()
        {
            CursoUnidadeFundLegals = new HashSet<CursoUnidadeFundLegalConfigurarion>();
        }   
    
    
    }
}

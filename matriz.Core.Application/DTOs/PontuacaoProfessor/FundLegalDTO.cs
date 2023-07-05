using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class FundLegalDTO
    {

        public int Id { get; private set; }
        public string Fundlegal { get; private set; } = string.Empty;

        public ICollection<CursoUnidadeFundLegalDTO> CursoUnidadeFundLegals { get;} = new List<CursoUnidadeFundLegalDTO>();
        public FundLegalDTO()
        {
            CursoUnidadeFundLegals = new HashSet<CursoUnidadeFundLegalDTO>();
        }   
    
    
    }
}

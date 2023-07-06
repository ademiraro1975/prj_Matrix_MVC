using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class FundLegalDTO
    {
        public FundLegalDTO(int id, string fundlegal)
        {
            Id = id;
            Fundlegal = fundlegal;
        }

        public int Id { get; private set; }
        public string Fundlegal { get; private set; } = string.Empty;

   
    
    }
}

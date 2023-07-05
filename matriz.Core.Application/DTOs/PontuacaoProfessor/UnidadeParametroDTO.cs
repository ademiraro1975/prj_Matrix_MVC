using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class UnidadeParametroDTO
    {
        public int IdUnidadeParametro { get; private set; }

        public string Descricao { get; private set; } = string.Empty;
        public ICollection<DetalheParametroDTO> DetalheParametro { get; } = new List<DetalheParametroDTO>();
        public UnidadeParametroDTO()
        {
            DetalheParametro = new HashSet<DetalheParametroDTO>();
        }
    }
}
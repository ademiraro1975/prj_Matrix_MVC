using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class ParametroDTO
    {
        public int IdParametro { get; private set; }

        public string? Descricao{ get; set; }

        public int? IdTipoParametro { get; private set; }

        public TipoParametroDTO TipoParametro { get; } = new TipoParametroDTO();

        public ICollection<DetalheParametroDTO> DetalheParametro { get; } = new List<DetalheParametroDTO>();
        public ParametroDTO()
        {
            DetalheParametro = new HashSet<DetalheParametroDTO>();
        }

    }
}
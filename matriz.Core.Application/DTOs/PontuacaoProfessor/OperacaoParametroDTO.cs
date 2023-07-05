using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class OperacaoParametroDTO
    {
        public int IdOperacaoParametro { get; private set; }

        public string DescricaoOperacaoAcesso { get; private set; } = string.Empty;
        public ICollection<DetalheParametroDTO> DetalheParametro { get; } = new List<DetalheParametroDTO>();
        public OperacaoParametroDTO()
        {
            DetalheParametro = new HashSet<DetalheParametroDTO>();
        }
    }
}
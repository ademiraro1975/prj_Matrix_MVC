using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class OperacaoParametroConfigurarion
    {
        public int IdOperacaoParametro { get; private set; }

        public string DescricaoOperacaoAcesso { get; private set; } = string.Empty;
        public ICollection<DetalheParametroConfigurarion> DetalheParametro { get; } = new List<DetalheParametroConfigurarion>();
        public OperacaoParametroConfigurarion()
        {
            DetalheParametro = new HashSet<DetalheParametroConfigurarion>();
        }
    }
}
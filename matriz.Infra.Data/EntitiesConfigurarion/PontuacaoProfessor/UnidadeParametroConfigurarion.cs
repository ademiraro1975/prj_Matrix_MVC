using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class UnidadeParametroConfigurarion
    {
        public int IdUnidadeParametro { get; private set; }

        public string Descricao { get; private set; } = string.Empty;
        public ICollection<DetalheParametroConfigurarion> DetalheParametro { get; } = new List<DetalheParametroConfigurarion>();
        public UnidadeParametroConfigurarion()
        {
            DetalheParametro = new HashSet<DetalheParametroConfigurarion>();
        }
    }
}
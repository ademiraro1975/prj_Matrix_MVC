using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class ParametroConfigurarion
    {
        public int IdParametro { get; private set; }

        public string? Descricao{ get; set; }

        public int? IdTipoParametro { get; private set; }

        public TipoParametroConfigurarion TipoParametro { get; } = new TipoParametroConfigurarion();

        public ICollection<DetalheParametroConfigurarion> DetalheParametro { get; } = new List<DetalheParametroConfigurarion>();
        public ParametroConfigurarion()
        {
            DetalheParametro = new HashSet<DetalheParametroConfigurarion>();
        }

    }
}
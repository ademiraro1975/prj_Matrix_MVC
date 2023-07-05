using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Parametro
    {
        public int IdParametro { get; private set; }

        public string? Descricao{ get; set; }

        public int? IdTipoParametro { get; private set; }

        public TipoParametro TipoParametro { get; } = new TipoParametro();

        public ICollection<DetalheParametro> DetalheParametro { get; } = new List<DetalheParametro>();
        public Parametro()
        {
            DetalheParametro = new HashSet<DetalheParametro>();
        }

    }
}
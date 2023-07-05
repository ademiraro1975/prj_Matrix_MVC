using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class UnidadeParametro
    {
        public int IdUnidadeParametro { get; private set; }

        public string Descricao { get; private set; } = string.Empty;
        public ICollection<DetalheParametro> DetalheParametro { get; } = new List<DetalheParametro>();
        public UnidadeParametro()
        {
            DetalheParametro = new HashSet<DetalheParametro>();
        }
    }
}
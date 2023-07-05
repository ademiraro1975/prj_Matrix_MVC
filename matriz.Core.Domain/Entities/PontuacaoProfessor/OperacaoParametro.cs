using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class OperacaoParametro
    {
        public int IdOperacaoParametro { get; private set; }

        public string DescricaoOperacaoAcesso { get; private set; } = string.Empty;
        public ICollection<DetalheParametro> DetalheParametro { get; } = new List<DetalheParametro>();
        public OperacaoParametro()
        {
            DetalheParametro = new HashSet<DetalheParametro>();
        }
    }
}
using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class ProcessoAtribuicao
    {
        public int IdProcessoAtribuicao { get; private set; }

        public string Descricao { get; private set; } = string.Empty;

        public DateTime DataInicio { get; private set; }

        public DateTime DataFim { get; private set; }

        public string Portaria { get; private set; } = string.Empty;

        public string Observacoes { get; private set; } = string.Empty;

        public string Ativo { get; private set; } = string.Empty;

        public ICollection<DetalheParametro> DetalheParametro { get; } = new List<DetalheParametro>();
        public ProcessoAtribuicao()
        {
            DetalheParametro = new HashSet<DetalheParametro>();
        }

    }
}
using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class DetalheParametro
    {
        public int IdDetalheParametro { get; set; }
        public int IdParametro { get; set; }

        public int IdProcessoAtribuicao { get; set; }

        public int IdOperacaoParametro { get; set; }

        public int IdUnidadeParametro { get; set; }

        public DateTime DataAlteracaoParam { get; set; }

        public decimal ValorParam { get; set; }

        public decimal LimiteParam { get; set; }

        public string UnidadeParam { get; set; }

        public Parametro Parametro { get; } = new Parametro();
        public ProcessoAtribuicao ProcessoAtribuicao { get; } = new ProcessoAtribuicao();
        public OperacaoParametro OperacaoParametro { get; } = new OperacaoParametro();
        public UnidadeParametro UnidadeParametro { get; } = new UnidadeParametro();

        public ICollection<DetalhePontuacao> DetalhePontuacao { get; } = new List<DetalhePontuacao>();
        public DetalheParametro()
        {
            DetalhePontuacao = new HashSet<DetalhePontuacao>();
        }
    }
}
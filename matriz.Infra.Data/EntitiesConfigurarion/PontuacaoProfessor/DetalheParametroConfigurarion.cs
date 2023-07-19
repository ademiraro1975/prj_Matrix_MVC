using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class DetalheParametroConfigurarion
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

        public ParametroConfigurarion Parametro { get; } = new ParametroConfigurarion();
        public ProcessoAtribuicaoConfigurarion ProcessoAtribuicao { get; } = new ProcessoAtribuicaoConfigurarion();
        public OperacaoParametroConfigurarion OperacaoParametro { get; } = new OperacaoParametroConfigurarion();
        public UnidadeParametroConfigurarion UnidadeParametro { get; } = new UnidadeParametroConfigurarion();

        public ICollection<DetalhePontuacaoConfigurarion> DetalhePontuacao { get; } = new List<DetalhePontuacaoConfigurarion>();
        public DetalheParametroConfigurarion()
        {
            DetalhePontuacao = new HashSet<DetalhePontuacaoConfigurarion>();
        }
    }
}
using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class DetalheParametroDTO
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

        public ParametroDTO Parametro { get; } = new ParametroDTO();
        public ProcessoAtribuicaoDTO ProcessoAtribuicao { get; } = new ProcessoAtribuicaoDTO();
        public OperacaoParametroDTO OperacaoParametro { get; } = new OperacaoParametroDTO();
        public UnidadeParametroDTO UnidadeParametro { get; } = new UnidadeParametroDTO();

        public ICollection<DetalhePontuacaoDTO> DetalhePontuacao { get; } = new List<DetalhePontuacaoDTO>();
        public DetalheParametroDTO()
        {
            DetalhePontuacao = new HashSet<DetalhePontuacaoDTO>();
        }
    }
}
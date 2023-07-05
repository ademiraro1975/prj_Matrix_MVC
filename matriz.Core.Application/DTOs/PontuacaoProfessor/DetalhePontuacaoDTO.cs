using System;
using System.Collections.Generic;
namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class DetalhePontuacaoDTO
    {
        public DetalhePontuacaoDTO(int idDetalhePontuacao, int idPontuacao, int idDetalheParametro, string tipoPontuacao, decimal quantidadePont, int quantidadeDias, int quantidadeDiasAnt, decimal quantidadePontAnt, DateTime dataConclusao)
        {
            IdDetalhePontuacao = idDetalhePontuacao;
            IdPontuacao = idPontuacao;
            IdDetalheParametro = idDetalheParametro;
            TipoPontuacao = tipoPontuacao;
            QuantidadePont = quantidadePont;
            QuantidadeDias = quantidadeDias;
            QuantidadeDiasAnt = quantidadeDiasAnt;
            QuantidadePontAnt = quantidadePontAnt;
            DataConclusao = dataConclusao;
        }

        public int IdDetalhePontuacao { get; private set; }

        public int IdPontuacao { get; private set; }

        public int IdDetalheParametro { get; private set; }

        public string TipoPontuacao { get; private set; } = string.Empty;

        public decimal QuantidadePont { get; private set; }

        public int QuantidadeDias { get; private set; }

        public int QuantidadeDiasAnt { get; private set; }

        public decimal QuantidadePontAnt { get; private set; }

        public DateTime DataConclusao { get; private set; }


    }
}
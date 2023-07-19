using System;
using System.Collections.Generic;
namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class DetalhePontuacao
    {
        public int IdDetalhePontuacao { get; private set; }

        public int IdPontuacao { get; private set; }

        public int IdDetalheParametro { get; private set; }

        public string TipoPontuacao { get; private set; } = string.Empty;

        public decimal QuantidadePont { get; private set; }

        public int QuantidadeDias { get; private set; }

        public int QuantidadeDiasAnt { get; private set; }

        public decimal QuantidadePontAnt { get; private set; }

        public DateTime DataConclusao { get; private set; }

        public Pontuacao Pontuacao { get; } = new Pontuacao();

        public DetalheParametro DetalheParametro { get; } = new DetalheParametro();


    }
}
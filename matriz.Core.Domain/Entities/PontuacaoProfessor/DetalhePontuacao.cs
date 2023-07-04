using System;
using System.Collections.Generic;
namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class DetalhePontuacao
    {
        public int CodigoControlePont { get; set; }

        public int? CodigoPont { get; set; }

        public int? CodigoParamPont { get; set; }

        public string? TipoPont { get; set; }

        public decimal? QuantidadePont { get; set; }

        public int? QuantidadeDias { get; set; }

        public int? QuantidadeDiasAnt { get; set; }

        public decimal? QuantidadePontAnt { get; set; }

        public DateTime? DataConclusao { get; set; }
    }
}
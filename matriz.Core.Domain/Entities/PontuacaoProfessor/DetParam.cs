using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class DetParam
    {
        public int CodigoDetParam { get; set; }

        public int? CodigoParam { get; set; }

        public int? CodigoProcessoAtrib { get; set; }

        public int? CodigoTipoParam { get; set; }

        public int? CodigoOperacaoParam { get; set; }

        public DateTime DataAlteracaoParam { get; set; }

        public decimal? ValorParam { get; set; }

        public decimal? LimiteParam { get; set; }

        public string? UnidadeParam { get; set; }

        public virtual Parametro? CodigoParamNavigation { get; set; }

        public virtual ProcessoAtrib? CodigoProcessoAtribNavigation { get; set; }
    }
}
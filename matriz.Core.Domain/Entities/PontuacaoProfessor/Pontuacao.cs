using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class Pontuacao
    {
        public int CodigoPont { get; set; }

        public int? CodigoProcessoAtribPont { get; set; }

        public int? MatriculaProfPont { get; set; }

        public decimal? PontuacaoEscolaPont { get; set; }

        public decimal? PontuacaoFiebPont { get; set; }

        public decimal? DeducoesPont { get; set; }

        public decimal? TituloPont { get; set; }
    }
}
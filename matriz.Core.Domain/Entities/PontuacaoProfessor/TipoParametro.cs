using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class TipoParametro
    {
        public int IdTipoParam { get; set; }

        public string? DescricaoTipoAcesso { get; set; }

        public string? AvrevTipoAcesso { get; set; }
    }
}
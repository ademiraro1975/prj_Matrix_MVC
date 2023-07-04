using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class Parametro
    {
        public int CodigoParam { get; set; }

        public string? DescricaoParam { get; set; }

        public int? CodigoTipoParam { get; set; }

        public virtual ICollection<DetParam> TblDetParams { get; } = new List<DetParam>();
    }
}
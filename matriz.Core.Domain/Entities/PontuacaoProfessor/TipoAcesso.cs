using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class TipoAcesso
    {
        public int IdTipoAcesso { get; set; }

        public string? DescricaoTipoAcesso { get; set; }

        public virtual ICollection<Usuario> TblUsuarios { get; } = new List<Usuario>();
    }
}
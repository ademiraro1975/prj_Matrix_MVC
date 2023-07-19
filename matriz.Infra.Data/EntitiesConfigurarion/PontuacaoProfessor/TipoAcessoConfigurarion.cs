using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class TipoAcessoConfigurarion
    {
        public int IdTipoAcesso { get; set; }

        public string? DescricaoTipoAcesso { get; set; }

        public virtual ICollection<UsuarioConfigurarion> TblUsuarios { get; } = new List<UsuarioConfigurarion>();
    }
}
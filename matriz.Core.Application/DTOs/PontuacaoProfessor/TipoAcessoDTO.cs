using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class TipoAcessoDTO
    {
        public int IdTipoAcesso { get; set; }

        public string? DescricaoTipoAcesso { get; set; }

        public virtual ICollection<UsuarioDTO> TblUsuarios { get; } = new List<UsuarioDTO>();
    }
}
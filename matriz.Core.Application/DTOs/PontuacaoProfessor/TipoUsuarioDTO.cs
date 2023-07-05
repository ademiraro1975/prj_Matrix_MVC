using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class TipoUsuarioDTO
    {

        public int Id { get;private set; }
        public string Descricao { get;private set; } = string.Empty;
        public int Hierarquia { get; private set; }
        public string Nomenclatura { get; private set; } = string.Empty;


        public ICollection<UsuarioDTO> Usuarios { get; } = new List<UsuarioDTO>();
        public TipoUsuarioDTO()
        {
            Usuarios = new HashSet<UsuarioDTO>();
        }

    }
}

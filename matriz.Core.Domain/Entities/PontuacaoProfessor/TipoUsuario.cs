using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class TipoUsuario
    {

        public int Id { get;private set; }
        public string Descricao { get;private set; } = string.Empty;
        public int Hierarquia { get; private set; }
        public string Nomenclatura { get; private set; } = string.Empty;


        public ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
        public TipoUsuario()
        {
            Usuarios = new HashSet<Usuario>();
        }

    }
}

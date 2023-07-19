using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class TipoUsuarioConfigurarion
    {

        public int Id { get;private set; }
        public string Descricao { get;private set; } = string.Empty;
        public int Hierarquia { get; private set; }
        public string Nomenclatura { get; private set; } = string.Empty;


        public ICollection<UsuarioConfigurarion> Usuarios { get; } = new List<UsuarioConfigurarion>();
        public TipoUsuarioConfigurarion()
        {
            Usuarios = new HashSet<UsuarioConfigurarion>();
        }

    }
}

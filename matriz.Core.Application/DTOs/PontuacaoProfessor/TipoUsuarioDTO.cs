using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class TipoUsuarioDTO
    {
        public TipoUsuarioDTO(int id, string descricao, int hierarquia, string nomenclatura)
        {
            Id = id;
            Descricao = descricao;
            Hierarquia = hierarquia;
            Nomenclatura = nomenclatura;
        }

        public int Id { get;private set; }
        public string Descricao { get;private set; } = string.Empty;
        public int Hierarquia { get; private set; }
        public string Nomenclatura { get; private set; } = string.Empty;




    }
}

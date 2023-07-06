using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class SistemaDTO
    {
        public SistemaDTO(int id, string descricao, string nomenclatura)
        {
            Id = id;
            Descricao = descricao;
            Nomenclatura = nomenclatura;
        }

        public int Id { get;private set; }
        public string Descricao { get;private set; } = string.Empty;
        public string Nomenclatura { get; private set; } = string.Empty;


    }
}

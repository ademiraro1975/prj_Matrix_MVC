using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class GrupoDisciplinaDTO
    {
        public GrupoDisciplinaDTO(int id, string descricao, string tipo)
        {
            Id = id;
            Descricao = descricao;
            Tipo = tipo;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; } = string.Empty;
        public string Tipo { get; private set; } = string.Empty;

 
    
    }
}

using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class DepartamentoDTO
    {
        public DepartamentoDTO(int id, string nome, string nomenclatura)
        {
            Id = id;
            Nome = nome;
            Nomenclatura = nomenclatura;
        }

        public int Id { get; set; }
        public string Nome { get; private set; } = string.Empty;
        public string Nomenclatura { get; private set; } = string.Empty;

 
    
    }
}

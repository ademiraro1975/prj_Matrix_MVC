using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class ModalidadeDTO
    {
        public ModalidadeDTO(int id, string descricao, bool modular, string nome, string nomenclatura)
        {
            Id = id;
            Descricao = descricao;
            Modular = modular;
            Nome = nome;
            Nomenclatura = nomenclatura;
        }

        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public bool Modular { get; set; } = false;
        public string Nome { get; set; } = string.Empty;
        public string Nomenclatura { get; set; } = string.Empty;


        
    }
}

using System;
using System.Collections.Generic;

namespace matriz.Core.Application.DTOs.Pizzaria
{
    public class RefrigeranteDTO
    {
        public RefrigeranteDTO(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public RefrigeranteDTO(int refrigeranteId, string nome, string descricao)
        {
            RefrigeranteId = refrigeranteId;
            Nome = nome;
            Descricao = descricao;
        }

        public int RefrigeranteId { get; set; }

        public string Nome { get; set; } = null!;

        public string Descricao { get; set; } = null!;

    }
}
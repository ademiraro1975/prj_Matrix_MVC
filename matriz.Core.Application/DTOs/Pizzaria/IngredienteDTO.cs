using System;
using System.Collections.Generic;

namespace matriz.Core.Application.DTOs.Pizzaria
{
    public class IngredienteDTO
    {
        public IngredienteDTO(int ingredienteId, string nome)
        {
            IngredienteId = ingredienteId;
            Nome = nome;
        }

        public int IngredienteId { get; set; }

        public string Nome { get; set; } = null!;

    }
}
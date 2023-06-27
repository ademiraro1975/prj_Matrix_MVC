using System;
using System.Collections.Generic;
namespace matriz.Core.Application.DTOs.Pizzaria
{
    public class FotoPizzaDTO
    {


        public FotoPizzaDTO(int pizzaId, string foto)
        {
            PizzaId = pizzaId;
            Foto = foto;
        }

        public FotoPizzaDTO(int fotoPizzaId, int pizzaId, string foto)
        {
            FotoPizzaId = fotoPizzaId;
            PizzaId = pizzaId;
            Foto = foto;
        }

        public int FotoPizzaId { get; set; }

        public int PizzaId { get; set; }

        public string Foto { get; set; } = null!;

    }
}
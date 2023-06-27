using System;
using System.Collections.Generic;

namespace matriz.Core.Application.DTOs.Pizzaria
{
    public class PizzaIngredienteDTO
    {

        public PizzaIngredienteDTO(int pizzaId, int ingredienteId)
        {
            PizzaId = pizzaId;
            IngredienteId = ingredienteId;
        }

        public PizzaIngredienteDTO(int pizzaId, int ingredienteId, string? nomeIngrediente)
        {
            PizzaId = pizzaId;
            IngredienteId = ingredienteId;
            NomeIngrediente = nomeIngrediente;
        }

        public PizzaIngredienteDTO(int pizzaIngredienteId, int pizzaId, int ingredienteId, string? nomeIngrediente)
        {
            PizzaIngredienteId = pizzaIngredienteId;
            PizzaId = pizzaId;
            IngredienteId = ingredienteId;
            NomeIngrediente = nomeIngrediente;
        }

        public int PizzaIngredienteId { get; set; }

        public int PizzaId { get; private set; }

        public int IngredienteId { get; private set; }

        public string? NomeIngrediente { get; private set; } = string.Empty;
    }
}
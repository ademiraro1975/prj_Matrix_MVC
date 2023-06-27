using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.Pizzaria
{

    public sealed class PizzaIngrediente
    {
        public PizzaIngrediente(int pizzaIngredienteId, int pizzaId, int ingredienteId)
        {
            PizzaIngredienteId = pizzaIngredienteId;
            PizzaId = pizzaId;
            IngredienteId = ingredienteId;
        }

        public PizzaIngrediente(int pizzaId, int ingredienteId)
        {
            PizzaId = pizzaId;
            IngredienteId = ingredienteId;
        }

        public int PizzaIngredienteId { get; private set; }

        public int PizzaId { get; private set; }

        public int IngredienteId { get; private set; }

        public Ingrediente Ingrediente { get; } = new Ingrediente();

        public Pizza Pizza { get; } = new Pizza();
    }
}
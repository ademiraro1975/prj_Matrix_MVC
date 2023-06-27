using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.Pizzaria
{

    public sealed class FotoPizza
    {
        public FotoPizza(int pizzaId, string foto)
        {
            PizzaId = pizzaId;
            Foto = foto;
        }

        public FotoPizza(int fotoPizzaId, int pizzaId, string foto)
        {
            FotoPizzaId = fotoPizzaId;
            PizzaId = pizzaId;
            Foto = foto;
        }

        public int FotoPizzaId { get; private set; }

        public int PizzaId { get; private set; }

        public string Foto { get; private set; } = string.Empty;

        public Pizza Pizza { get; } = new Pizza();
    }
}
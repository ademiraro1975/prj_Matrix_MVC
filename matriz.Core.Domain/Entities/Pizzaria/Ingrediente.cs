using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.Pizzaria
{

    public sealed class Ingrediente
    {
        public int IngredienteId { get; private set; }

        public string Nome { get; private set; } = string.Empty;
        public ICollection<PizzaIngrediente> PizzaIngredientes { get; } = new List<PizzaIngrediente>();


        public Ingrediente()
        {
            PizzaIngredientes = new HashSet<PizzaIngrediente>();
        }

        public Ingrediente(int ingredienteId, string nome)
        {
            IngredienteId = ingredienteId;
            Nome = nome;
        }

        public Ingrediente(string nome)
        {
            Nome = nome;
        }
    }
}
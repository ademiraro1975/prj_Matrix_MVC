using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.Pizzaria
{
    public sealed class Pizza
    {
        public int PizzaId { get; private set; }

        public string Nome { get; private set; } = string.Empty;

        public string Descricao { get; private set; } = string.Empty;

        public string Foto { get; private set; } = string.Empty;

        public ICollection<FotoPizza> FotoPizzas { get; } = new List<FotoPizza>();
        public ICollection<PizzaDetalhe> PizzaDetalhes { get; } = new List<PizzaDetalhe>();
        public ICollection<PizzaIngrediente> PizzaIngredientes { get; } = new List<PizzaIngrediente>();


        public Pizza()
        {
            FotoPizzas = new HashSet<FotoPizza>();
            PizzaDetalhes = new HashSet<PizzaDetalhe>();
            PizzaIngredientes = new HashSet<PizzaIngrediente>();
        }

        public Pizza(int pizzaId, string nome, string descricao)
        {
            PizzaId = pizzaId;
            Nome = nome;
            Descricao = descricao;
        }

        public Pizza(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public Pizza(int pizzaId, string nome, string descricao, ICollection<FotoPizza> fotoPizzas)
        {
            PizzaId = pizzaId;
            Nome = nome;
            Descricao = descricao;
            FotoPizzas = fotoPizzas;
        }

        public Pizza(int pizzaId, string nome, string descricao, string foto)
        {
            PizzaId = pizzaId;
            Nome = nome;
            Descricao = descricao;
            Foto = foto;
        }
    }
}
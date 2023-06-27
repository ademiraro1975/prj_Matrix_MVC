using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.Pizzaria
{

    public sealed class TabelaPreco
    {
        public int TabelaPrecoId { get; private set; }

        public decimal Preco { get; private set; }

        public ICollection<PizzaDetalhe> PizzaDetalhes { get; } = new List<PizzaDetalhe>();
        public ICollection<RefrigeranteDetalhe> RefrigeranteDetalhes { get; } = new List<RefrigeranteDetalhe>();

        public TabelaPreco()
        {
            PizzaDetalhes = new HashSet<PizzaDetalhe>();
            RefrigeranteDetalhes = new HashSet<RefrigeranteDetalhe>();
        }

        public TabelaPreco(int tabelaPrecoId, decimal preco)
        {
            TabelaPrecoId = tabelaPrecoId;
            Preco = preco;
        }

        public TabelaPreco(decimal preco)
        {
            Preco = preco;
        }
    }
}
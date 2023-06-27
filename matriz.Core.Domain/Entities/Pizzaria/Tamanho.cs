using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.Pizzaria
{
    public sealed class Tamanho
    {
        public int TamanhoId { get; private set; }

        public string Descricao { get; private set; } = string.Empty;

        public int NumPedaco { get; private set; }

        public ICollection<PizzaDetalhe> PizzaDetalhes { get; } = new List<PizzaDetalhe>();
        public ICollection<RefrigeranteDetalhe> RefrigeranteDetalhes { get; } = new List<RefrigeranteDetalhe>();

        public Tamanho()
        {
            PizzaDetalhes = new HashSet<PizzaDetalhe>();
            RefrigeranteDetalhes = new HashSet<RefrigeranteDetalhe>();
        }

        public Tamanho(int tamanhoId, string descricao, int numPedaco)
        {
            TamanhoId = tamanhoId;
            Descricao = descricao;
            NumPedaco = numPedaco;
        }

        public Tamanho(string descricao, int numPedaco)
        {
            Descricao = descricao;
            NumPedaco = numPedaco;
        }
    }
}
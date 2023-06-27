using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace matriz.Core.Domain.Entities.Pizzaria
{

    public sealed class PizzaDetalhe
    {
        public PizzaDetalhe(int pizzaId, int tabelaPrecoId, int tamanhoId, int tipoId)
        {
            PizzaId = pizzaId;
            TabelaPrecoId = tabelaPrecoId;
            TamanhoId = tamanhoId;
            TipoId = tipoId;
        }

        public PizzaDetalhe(int pizzaDetalheId, int pizzaId, int tabelaPrecoId, int tamanhoId, int tipoId)
        {
            PizzaDetalheId = pizzaDetalheId;
            PizzaId = pizzaId;
            TabelaPrecoId = tabelaPrecoId;
            TamanhoId = tamanhoId;
            TipoId = tipoId;
        }

        public PizzaDetalhe(int pizzaId, int tabelaPrecoId, int tamanhoId, int tipoId, string precoDP, string tamanhoDP, string tipoDP)
        {
            PizzaId = pizzaId;
            TabelaPrecoId = tabelaPrecoId;
            TamanhoId = tamanhoId;
            TipoId = tipoId;
            this.precoDP = precoDP;
            this.tamanhoDP = tamanhoDP;
            this.tipoDP = tipoDP;
        }

        public PizzaDetalhe(int pizzaDetalheId, int pizzaId, int tabelaPrecoId, int tamanhoId, int tipoId, string precoDP, string tamanhoDP, string tipoDP)
        {
            PizzaDetalheId = pizzaDetalheId;
            PizzaId = pizzaId;
            TabelaPrecoId = tabelaPrecoId;
            TamanhoId = tamanhoId;
            TipoId = tipoId;
            this.precoDP = precoDP;
            this.tamanhoDP = tamanhoDP;
            this.tipoDP = tipoDP;
        }

        public int PizzaDetalheId { get; private set; }

        public int PizzaId { get; private set; }

        public int TabelaPrecoId { get; private set; }

        public int TamanhoId { get; private set; }

        public int TipoId { get; private set; }

        [NotMapped]
        public string precoDP { get; private set; } = string.Empty;
        [NotMapped]
        public string tamanhoDP { get; private set; } = string.Empty;
        [NotMapped]
        public string tipoDP { get; private set; } = string.Empty;

        public Pizza Pizza { get; } = new Pizza();

        public TabelaPreco TabelaPreco { get; } = new TabelaPreco();

        public Tamanho Tamanho { get; } = new Tamanho();

        public Tipo Tipo { get; } = new Tipo();
    }
}
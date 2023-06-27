using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace matriz.Core.Application.DTOs.Pizzaria
{
    public class PizzaDetalheDTO
    {
        public PizzaDetalheDTO(int pizzaId, int tabelaPrecoId, int tamanhoId, int tipoId)
        {
            PizzaId = pizzaId;
            TabelaPrecoId = tabelaPrecoId;
            TamanhoId = tamanhoId;
            TipoId = tipoId;
        }

        public PizzaDetalheDTO(int pizzaDetalheId, int pizzaId, int tabelaPrecoId, int tamanhoId, int tipoId)
        {
            PizzaDetalheId = pizzaDetalheId;
            PizzaId = pizzaId;
            TabelaPrecoId = tabelaPrecoId;
            TamanhoId = tamanhoId;
            TipoId = tipoId;
        }

        public PizzaDetalheDTO(int pizzaDetalheId, int pizzaId, int tabelaPrecoId, int tamanhoId, int tipoId, string precoPD, string tamanhoPD, string tipoPD)
        {
            PizzaDetalheId = pizzaDetalheId;

            PizzaId = pizzaId;

            TabelaPrecoId = tabelaPrecoId;

            TamanhoId = tamanhoId;

            TipoId = tipoId;

            precoPD = precoPD;
            tamanhoPD = tamanhoPD;
            tipoPD = tipoPD;
        }

        public int PizzaDetalheId { get; set; }

        public int PizzaId { get; set; }

        public int TabelaPrecoId { get; set; }

        public int TamanhoId { get; set; }

        public int TipoId { get; set; }

        [NotMapped]
        public string precoDP { get; private set; } = string.Empty;
        [NotMapped]
        public string tamanhoDP { get; private set; } = string.Empty;
        [NotMapped]
        public string tipoDP { get; private set; } = string.Empty;


    }
}
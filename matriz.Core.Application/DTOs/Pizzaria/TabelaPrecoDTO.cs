using System;
using System.Collections.Generic;

namespace matriz.Core.Application.DTOs.Pizzaria
{
    public class TabelaPrecoDTO
    {
        public TabelaPrecoDTO(int tabelaPrecoId, decimal preco)
        {
            TabelaPrecoId = tabelaPrecoId;
            Preco = preco;
        }

        public int TabelaPrecoId { get; set; }

        public decimal Preco { get; set; }

    }
}
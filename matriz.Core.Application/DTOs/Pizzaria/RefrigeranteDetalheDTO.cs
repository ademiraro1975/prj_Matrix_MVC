using System;
using System.Collections.Generic;

namespace matriz.Core.Application.DTOs.Pizzaria
{
    public class RefrigeranteDetalheDTO
    {
        public RefrigeranteDetalheDTO(int refrigeranteDetalheId, int refrigeranteId, int tabelaPrecoId, int tamanhoId, int tipoId)
        {
            RefrigeranteDetalheId = refrigeranteDetalheId;
            RefrigeranteId = refrigeranteId;
            TabelaPrecoId = tabelaPrecoId;
            TamanhoId = tamanhoId;
            TipoId = tipoId;
        }

        public int RefrigeranteDetalheId { get; set; }

        public int RefrigeranteId { get; set; }

        public int TabelaPrecoId { get; set; }

        public int TamanhoId { get; set; }

        public int TipoId { get; set; }


    }
}
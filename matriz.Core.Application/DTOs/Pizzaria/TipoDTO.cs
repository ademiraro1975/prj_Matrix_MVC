using System;
using System.Collections.Generic;

namespace matriz.Core.Application.DTOs.Pizzaria
{
    public class TipoDTO
    {
        public TipoDTO(int tipoId, string descricao)
        {
            TipoId = tipoId;
            Descricao = descricao;
        }

        public int TipoId { get; set; }

        public string Descricao { get; set; } = null!;

    }
}
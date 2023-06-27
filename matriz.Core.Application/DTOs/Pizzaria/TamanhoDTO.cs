using System;
using System.Collections.Generic;

namespace matriz.Core.Application.DTOs.Pizzaria
{
    public class TamanhoDTO
    {
        public TamanhoDTO(int tamanhoId, string descricao, int numPedaco)
        {
            TamanhoId = tamanhoId;
            Descricao = descricao;
            NumPedaco = numPedaco;
        }

        public int TamanhoId { get; set; }

        public string Descricao { get; set; } = null!;

        public int NumPedaco { get; set; }

    }
}
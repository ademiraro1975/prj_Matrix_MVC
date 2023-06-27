using System;
using System.Collections.Generic;

namespace matriz.Core.Application.DTOs.Pizzaria
{
    public class FotoRefrigeranteDTO
    {
        public FotoRefrigeranteDTO(int fotoRefrigeranteId, int refrigeranteId, string foto)
        {
            FotoRefrigeranteId = fotoRefrigeranteId;
            RefrigeranteId = refrigeranteId;
            Foto = foto;
        }

        public int FotoRefrigeranteId { get; set; }

        public int RefrigeranteId { get; set; }

        public string Foto { get; set; } = null!;

    }
}
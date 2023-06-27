using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.Pizzaria
{
    public sealed class FotoRefrigerante
    {
        public FotoRefrigerante(int refrigeranteId, string foto)
        {
            RefrigeranteId = refrigeranteId;
            Foto = foto;
        }

        public FotoRefrigerante(int fotoRefrigeranteId, int refrigeranteId, string foto)
        {
            FotoRefrigeranteId = fotoRefrigeranteId;
            RefrigeranteId = refrigeranteId;
            Foto = foto;
        }

        public int FotoRefrigeranteId { get; private set; }

        public int RefrigeranteId { get; private set; }

        public string Foto { get; private set; } = string.Empty;

        public Refrigerante Refrigerante { get; } = new Refrigerante();
    }
}
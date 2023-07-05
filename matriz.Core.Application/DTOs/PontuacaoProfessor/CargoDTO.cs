using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CargoDTO
    {
        public CargoDTO(int id, string? nomenclatura, string titulo)
        {
            Id = id;
            Nomenclatura = nomenclatura;
            Titulo = titulo;
        }

        public int Id { get;private set; }
        public string? Nomenclatura { get;private set; } = string.Empty;
        public string Titulo { get; private set; } = string.Empty;


    
    }
}

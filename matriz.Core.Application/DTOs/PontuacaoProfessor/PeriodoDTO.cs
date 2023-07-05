using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class PeriodoDTO
    {

        public int Id { get; private set; }
        public DateTime HoraFim { get; private set; }
        public DateTime HoraInicio { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string Sigla { get; private set; } = string.Empty;


        public ICollection<ClasseDTO> Classes { get; } = new List<ClasseDTO>();
        public  ICollection<CursoUnidadePeriodoDTO> CursoUnidadePeriodos { get; } = new List<CursoUnidadePeriodoDTO>();
        public PeriodoDTO()
        {
            Classes = new HashSet<ClasseDTO>();
            CursoUnidadePeriodos = new HashSet<CursoUnidadePeriodoDTO>();
        }


    }
}

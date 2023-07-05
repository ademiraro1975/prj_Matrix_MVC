using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CursoUnidadePeriodoDTO
    {
        public CursoUnidadePeriodoDTO(int id, DateTime horaFim, DateTime horaInicio, int cursoUnidadeId, int periodoId)
        {
            Id = id;
            HoraFim = horaFim;
            HoraInicio = horaInicio;
            CursoUnidadeId = cursoUnidadeId;
            PeriodoId = periodoId;
        }

        public int Id { get; private set; }
        public DateTime HoraFim { get; private set; }
        public DateTime HoraInicio { get; private set; } 
        public int CursoUnidadeId { get; private set; }
        public int PeriodoId { get; private set; }


    }
}

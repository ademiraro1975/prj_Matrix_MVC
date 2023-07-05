using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CursoUnidadePeriodo
    {

        public int Id { get; private set; }
        public DateTime HoraFim { get; private set; }
        public DateTime HoraInicio { get; private set; } 

        public int CursoUnidadeId { get; private set; }
        public int PeriodoId { get; private set; }

        public CursoUnidade CursoUnidade { get; } = new CursoUnidade();
        public Periodo Periodo { get; } = new Periodo();

    }
}

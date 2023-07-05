using matriz.Core.Domain.Entities.PontuacaoProfessor;
using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CursoAreaDTO
    {
        public CursoAreaDTO(int id, int anoFim, int anoInicio, byte cicloFim, byte cicloInicio, int cursoId, int areaId)
        {
            Id = id;
            AnoFim = anoFim;
            AnoInicio = anoInicio;
            CicloFim = cicloFim;
            CicloInicio = cicloInicio;
            CursoId = cursoId;
            AreaId = areaId;
        }

        public int Id { get; private set; }
        public int AnoFim { get; private set; }
        public int AnoInicio { get; private set; }
        public byte CicloFim { get; private set; }
        public byte CicloInicio { get; private set; }
        public int CursoId { get; private set; }
        public int AreaId { get; private set; }


    }
}

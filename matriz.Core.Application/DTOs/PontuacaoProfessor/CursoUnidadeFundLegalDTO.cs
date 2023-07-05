using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CursoUnidadeFundLegalDTO
    {
        public CursoUnidadeFundLegalDTO(int id, int? anoFim, int anoInicio, byte? cicloFim, byte cicloInicio, DateTime? dataParecer, int fundLegalId, int cursoUnidadeId)
        {
            Id = id;
            AnoFim = anoFim;
            AnoInicio = anoInicio;
            CicloFim = cicloFim;
            CicloInicio = cicloInicio;
            DataParecer = dataParecer;
            FundLegalId = fundLegalId;
            CursoUnidadeId = cursoUnidadeId;
        }

        public int Id { get; private set; }
        public int? AnoFim { get; private set; }
        public int AnoInicio { get; private set; }
        public byte? CicloFim { get; private set; }
        public byte CicloInicio { get; private set; }
        public DateTime? DataParecer { get; private set; }
        public int FundLegalId { get; private set; }
        public int CursoUnidadeId { get; private set; }

    }
}

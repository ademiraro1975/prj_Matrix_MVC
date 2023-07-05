using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CursoUnidadeFundLegal
    {

        public int Id { get; private set; }

        public int? AnoFim { get; private set; }
        public int AnoInicio { get; private set; }
        public byte? CicloFim { get; private set; }
        public byte CicloInicio { get; private set; }
        public DateTime? DataParecer { get; private set; }

        public int FundLegalId { get; private set; }
        public int CursoUnidadeId { get; private set; }

        public CursoUnidade CursoUnidades { get; } = new CursoUnidade();
        public FundLegal FundLegals { get; } = new FundLegal();
    }
}

using matriz.Core.Domain.Entities.PontuacaoProfessor;
using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CursoArea
    {

        public int Id { get; private set; }

        public int AnoFim { get; private set; }
        public int AnoInicio { get; private set; }
        public byte CicloFim { get; private set; }
        public byte CicloInicio { get; private set; }


        public int CursoId { get; private set; }
        public int AreaId { get; private set; }

        public AreaConhecimento AreaConhecimento { get; } = new AreaConhecimento();
        public Curso Curso { get; } = new Curso();
    }
}

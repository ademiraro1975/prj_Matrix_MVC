using matriz.Core.Domain.Entities.PontuacaoProfessor;
using matriz.Infra.Data.EntitiesConfigurarion.PontuacaoProfessor;
using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CursoAreaConfigurarion
    {

        public int Id { get; private set; }

        public int AnoFim { get; private set; }
        public int AnoInicio { get; private set; }
        public byte CicloFim { get; private set; }
        public byte CicloInicio { get; private set; }


        public int CursoId { get; private set; }
        public int AreaId { get; private set; }

        public AreaConhecimentoConfiguration AreaConhecimento { get; } = new AreaConhecimentoConfigurarion();
        public CursoConfigurarion Curso { get; } = new CursoConfigurarion();
    }
}

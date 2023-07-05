using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CursoHabilitacaoDTO
    {
        public CursoHabilitacaoDTO(int id, int? ordem, int cursoId, int habilitacaoId)
        {
            Id = id;
            Ordem = ordem;
            CursoId = cursoId;
            HabilitacaoId = habilitacaoId;
        }

        public int Id { get;private set; }
        public int? Ordem { get;private set; }
        public int CursoId { get; private set; }
        public int HabilitacaoId { get; private set; }

    }
}

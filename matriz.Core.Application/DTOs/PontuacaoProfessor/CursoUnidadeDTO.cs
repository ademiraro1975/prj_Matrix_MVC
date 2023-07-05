using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CursoUnidadeDTO
    {
        public CursoUnidadeDTO(int id, bool estagio, bool status, bool tCC, int cursoId, int unidadeId)
        {
            Id = id;
            Estagio = estagio;
            Status = status;
            TCC = tCC;
            CursoId = cursoId;
            UnidadeId = unidadeId;
        }

        public int Id { get; private set; }
        public bool Estagio { get; private set; } = false;
        public bool Status { get; private set; } = false;
        public bool TCC { get; private set; } = false;
        public int CursoId { get; private set; }
        public int UnidadeId { get; private set; }
   
    
    }
}

using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class DepartamentoUnidadeDTO
    {
        public DepartamentoUnidadeDTO(int id, int departamentoId, int unidadeId)
        {
            Id = id;
            DepartamentoId = departamentoId;
            UnidadeId = unidadeId;
        }

        public int Id { get; private set; }
        public int DepartamentoId { get; private set; }
        public int UnidadeId { get; private set; }


    }
}

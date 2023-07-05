using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class DepartamentoUnidadeDTO
    {

        public int Id { get; private set; }
        public int DepartamentoId { get; private set; }
        public int UnidadeId { get; private set; }

        public DepartamentoDTO Departamento { get; } = new DepartamentoDTO();
        public UnidadeDTO Unidade { get; } = new UnidadeDTO();

        public ICollection<CargoDepartamentoUnidadeDTO> CargoDepartamentoUnidades { get; } = new List<CargoDepartamentoUnidadeDTO>();
        public DepartamentoUnidadeDTO()
        {
            CargoDepartamentoUnidades = new HashSet<CargoDepartamentoUnidadeDTO>();
        }

    }
}

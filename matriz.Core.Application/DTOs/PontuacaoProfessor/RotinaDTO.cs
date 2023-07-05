using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class RotinaDTO
    {


        public int Id { get;private set; }

        public string Descricao { get;private set; } = string.Empty;
        public int Menuordem { get; private set; }
        public string Nomenclatura { get; private set; } = string.Empty;
        public int Prioridade { get; private set; }

        public int SistemaId { get; private set; }

        public SistemaDTO Sistema { get; } = new SistemaDTO();

        public ICollection<RotinaOperacaoDTO> RotinaOperacaos { get; }
        public RotinaDTO()
        {
            RotinaOperacaos = new HashSet<RotinaOperacaoDTO>();
        }
    }
}

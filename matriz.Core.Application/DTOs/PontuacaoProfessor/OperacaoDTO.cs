using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class OperacaoDTO
    {

        public int Id { get; private set; }
        public string Descricao { get; private set; } = string.Empty;
        public string Nomenclatura { get; private set; } = string.Empty;

        public ICollection<RotinaOperacaoDTO> RotinaOperacaos { get; } = new List<RotinaOperacaoDTO>();
        public OperacaoDTO()
        {
            RotinaOperacaos = new HashSet<RotinaOperacaoDTO>();
        }
    }
}

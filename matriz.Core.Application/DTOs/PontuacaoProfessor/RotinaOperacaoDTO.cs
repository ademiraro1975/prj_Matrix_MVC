using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class RotinaOperacaoDTO
    {
        public RotinaOperacaoDTO(int id, bool novaaba, int rotinaId, int operacaoId, int rotinaOperacaoPaiId)
        {
            Id = id;
            Novaaba = novaaba;
            RotinaId = rotinaId;
            OperacaoId = operacaoId;
            RotinaOperacaoPaiId = rotinaOperacaoPaiId;
        }

        public int Id { get;private set; }
        public bool Novaaba { get; private set; } = false;
        public int RotinaId { get; private set; }
        public int OperacaoId { get;private set; }
        public int RotinaOperacaoPaiId { get; private set; }


    }
}

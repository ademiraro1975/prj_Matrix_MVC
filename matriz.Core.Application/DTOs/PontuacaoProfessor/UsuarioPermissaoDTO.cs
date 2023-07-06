using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class UsuarioPermissaoDTO
    {
        public UsuarioPermissaoDTO(int id, int rotinaOperacaoId, int unidadeId, int usuarioId)
        {
            Id = id;
            RotinaOperacaoId = rotinaOperacaoId;
            UnidadeId = unidadeId;
            UsuarioId = usuarioId;
        }

        public int Id { get;private set; }
        public int RotinaOperacaoId { get;private set; }
        public int UnidadeId { get; private set; }
        public int UsuarioId { get; private set; }


    }
}

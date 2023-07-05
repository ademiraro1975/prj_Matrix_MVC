using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class UsuarioPermissaoDTO
    {
        public int Id { get;private set; }


        public int RotinaOperacaoId { get;private set; }
        public int UnidadeId { get; private set; }
        public int UsuarioId { get; private set; }


        public RotinaOperacaoDTO RotinaOperacao { get; } = new RotinaOperacaoDTO();
        public UnidadeDTO Unidade { get; } = new UnidadeDTO();
        public UsuarioDTO Usuario { get; } = new UsuarioDTO();

    }
}

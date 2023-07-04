using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class UsuarioPermissao
    {
        public int Id { get;private set; }


        public int RotinaOperacaoId { get;private set; }
        public int UnidadeId { get; private set; }
        public int UsuarioId { get; private set; }


        public RotinaOperacao RotinaOperacao { get; } = new RotinaOperacao();
        public Unidade Unidade { get; } = new Unidade();
        public Usuario Usuario { get; } = new Usuario();

    }
}

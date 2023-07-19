using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class UsuarioPermissaoConfigurarion
    {
        public int Id { get;private set; }


        public int RotinaOperacaoId { get;private set; }
        public int UnidadeId { get; private set; }
        public int UsuarioId { get; private set; }


        public RotinaOperacaoConfigurarion RotinaOperacao { get; } = new RotinaOperacaoConfigurarion();
        public UnidadeConfigurarion Unidade { get; } = new UnidadeConfigurarion();
        public UsuarioConfigurarion Usuario { get; } = new UsuarioConfigurarion();

    }
}

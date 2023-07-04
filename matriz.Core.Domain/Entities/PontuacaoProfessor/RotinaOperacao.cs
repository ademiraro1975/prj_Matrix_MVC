using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class RotinaOperacao
    {

        public int Id { get;private set; }
        public bool Novaaba { get; private set; } = false;

        public int RotinaId { get; private set; }
        public int OperacaoId { get;private set; }
        public int RotinaOperacaoPaiId { get; private set; }

        public Operacao Operacao { get; } = new Operacao();    
        public Rotina Rotina { get;} = new Rotina();

        public ICollection<LogSistema> LogSistemas { get; } = new List<LogSistema>();
        public ICollection<UsuarioPermissao> UsuarioPermissaos { get;} = new List<UsuarioPermissao>();
        public ICollection<RotinaOperacao> RotinaOperacaos { get; } = new List<RotinaOperacao>();
        public RotinaOperacao()
        {
            LogSistemas = new HashSet<LogSistema>();
            RotinaOperacaos = new HashSet<RotinaOperacao>();
            UsuarioPermissaos = new HashSet<UsuarioPermissao>();
        }
    }
}

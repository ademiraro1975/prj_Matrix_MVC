using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class RotinaOperacaoConfigurarion
    {

        public int Id { get;private set; }
        public bool Novaaba { get; private set; } = false;

        public int RotinaId { get; private set; }
        public int OperacaoId { get;private set; }
        public int RotinaOperacaoPaiId { get; private set; }

        public OperacaoConfigurarion Operacao { get; } = new OperacaoConfigurarion();    
        public RotinaConfigurarion Rotina { get;} = new RotinaConfigurarion();

        public ICollection<LogSistemaConfigurarion> LogSistemas { get; } = new List<LogSistemaConfigurarion>();
        public ICollection<UsuarioPermissaoConfigurarion> UsuarioPermissaos { get;} = new List<UsuarioPermissaoConfigurarion>();
        public ICollection<RotinaOperacaoConfigurarion> RotinaOperacaos { get; } = new List<RotinaOperacaoConfigurarion>();
        public RotinaOperacaoConfigurarion()
        {
            LogSistemas = new HashSet<LogSistemaConfigurarion>();
            RotinaOperacaos = new HashSet<RotinaOperacaoConfigurarion>();
            UsuarioPermissaos = new HashSet<UsuarioPermissaoConfigurarion>();
        }
    }
}

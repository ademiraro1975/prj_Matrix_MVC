using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class RotinaOperacaoDTO
    {

        public int Id { get;private set; }
        public bool Novaaba { get; private set; } = false;

        public int RotinaId { get; private set; }
        public int OperacaoId { get;private set; }
        public int RotinaOperacaoPaiId { get; private set; }

        public OperacaoDTO Operacao { get; } = new OperacaoDTO();    
        public RotinaDTO Rotina { get;} = new RotinaDTO();

        public ICollection<LogSistemaDTO> LogSistemas { get; } = new List<LogSistemaDTO>();
        public ICollection<UsuarioPermissaoDTO> UsuarioPermissaos { get;} = new List<UsuarioPermissaoDTO>();
        public ICollection<RotinaOperacaoDTO> RotinaOperacaos { get; } = new List<RotinaOperacaoDTO>();
        public RotinaOperacaoDTO()
        {
            LogSistemas = new HashSet<LogSistemaDTO>();
            RotinaOperacaos = new HashSet<RotinaOperacaoDTO>();
            UsuarioPermissaos = new HashSet<UsuarioPermissaoDTO>();
        }
    }
}

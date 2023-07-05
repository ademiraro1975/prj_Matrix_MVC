using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class LogSistemaDTO
    {
        public int Id { get;private set; }
        public DateTime Datacadastro { get;private set; }
        public string Detalhe { get; private set; } = string.Empty;
        public string MaquinaIP { get; private set; } = string.Empty;
        public string Navegador { get; private set; } = string.Empty;

        public int UsuarioId { get; private set; }
        public int RotinaOperacaoId { get; private set; }
        public int SistemaId { get; private set; }
        public int RegistroId { get; private set; }


        public RotinaOperacaoDTO RotinaOperacao { get;} = new RotinaOperacaoDTO();
        public SistemaDTO Sistema { get; } = new SistemaDTO();
        public UsuarioDTO Usuario { get; } = new UsuarioDTO();

    }
}

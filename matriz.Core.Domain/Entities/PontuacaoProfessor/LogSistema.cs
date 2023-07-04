using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class LogSistema
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


        public RotinaOperacao RotinaOperacao { get;} = new RotinaOperacao();
        public Sistema Sistema { get; } = new Sistema();
        public Usuario Usuario { get; } = new Usuario();

    }
}

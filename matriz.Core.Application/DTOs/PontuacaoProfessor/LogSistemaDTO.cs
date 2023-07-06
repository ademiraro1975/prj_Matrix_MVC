using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class LogSistemaDTO
    {
        public LogSistemaDTO(int id, DateTime datacadastro, string detalhe, string maquinaIP, string navegador, int usuarioId, int rotinaOperacaoId, int sistemaId, int registroId)
        {
            Id = id;
            Datacadastro = datacadastro;
            Detalhe = detalhe;
            MaquinaIP = maquinaIP;
            Navegador = navegador;
            UsuarioId = usuarioId;
            RotinaOperacaoId = rotinaOperacaoId;
            SistemaId = sistemaId;
            RegistroId = registroId;
        }

        public int Id { get;private set; }
        public DateTime Datacadastro { get;private set; }
        public string Detalhe { get; private set; } = string.Empty;
        public string MaquinaIP { get; private set; } = string.Empty;
        public string Navegador { get; private set; } = string.Empty;
        public int UsuarioId { get; private set; }
        public int RotinaOperacaoId { get; private set; }
        public int SistemaId { get; private set; }
        public int RegistroId { get; private set; }


    }
}

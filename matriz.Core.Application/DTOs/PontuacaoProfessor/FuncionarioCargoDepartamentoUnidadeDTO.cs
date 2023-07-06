using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class FuncionarioCargoDepartamentoUnidadeDTO
    {
        public FuncionarioCargoDepartamentoUnidadeDTO(int id, bool ativo, string emaildocente, long matricula, bool segundoCargo, int atribuicaoId, int funcionarioId, int cargoDepartamentoUnidadeId)
        {
            Id = id;
            Ativo = ativo;
            Emaildocente = emaildocente;
            Matricula = matricula;
            SegundoCargo = segundoCargo;
            AtribuicaoId = atribuicaoId;
            FuncionarioId = funcionarioId;
            CargoDepartamentoUnidadeId = cargoDepartamentoUnidadeId;
        }

        public int Id { get; private set; }
        public bool Ativo { get; private set; } = false;
        public string Emaildocente { get; private set; } = string.Empty;
        public long Matricula { get; private set; }
        public bool SegundoCargo { get; private set; } = false;
        public int AtribuicaoId { get; private set; }
        public int FuncionarioId { get; private set; }
        public int CargoDepartamentoUnidadeId { get; set; }

    }
}

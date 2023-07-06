using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class OperacaoParametroDTO
    {
        public OperacaoParametroDTO(int idOperacaoParametro, string descricaoOperacaoAcesso)
        {
            IdOperacaoParametro = idOperacaoParametro;
            DescricaoOperacaoAcesso = descricaoOperacaoAcesso;
        }

        public int IdOperacaoParametro { get; private set; }

        public string DescricaoOperacaoAcesso { get; private set; } = string.Empty;

    }
}
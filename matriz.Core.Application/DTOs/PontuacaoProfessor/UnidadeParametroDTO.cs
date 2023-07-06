using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class UnidadeParametroDTO
    {
        public UnidadeParametroDTO(int idUnidadeParametro, string descricao)
        {
            IdUnidadeParametro = idUnidadeParametro;
            Descricao = descricao;
        }

        public int IdUnidadeParametro { get; private set; }

        public string Descricao { get; private set; } = string.Empty;

    }
}
using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class TipoParametroDTO
    {
        public TipoParametroDTO(int idTipoParametro, string descricaoTipoAcesso, string abreviacao)
        {
            IdTipoParametro = idTipoParametro;
            DescricaoTipoAcesso = descricaoTipoAcesso;
            Abreviacao = abreviacao;
        }

        public int IdTipoParametro { get; private set; }

        public string DescricaoTipoAcesso { get; private set; } = string.Empty;

        public string Abreviacao { get; private set; } = string.Empty;
    }
}
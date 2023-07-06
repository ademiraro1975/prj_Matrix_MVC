using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class ParametroDTO
    {
        public ParametroDTO(int idParametro, string? descricao, int? idTipoParametro)
        {
            IdParametro = idParametro;
            Descricao = descricao;
            IdTipoParametro = idTipoParametro;
        }

        public int IdParametro { get; private set; }

        public string? Descricao{ get; set; }

        public int? IdTipoParametro { get; private set; }



    }
}
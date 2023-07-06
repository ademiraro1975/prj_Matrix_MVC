using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class TipoAcessoDTO
    {
        public TipoAcessoDTO(int idTipoAcesso, string? descricaoTipoAcesso)
        {
            IdTipoAcesso = idTipoAcesso;
            DescricaoTipoAcesso = descricaoTipoAcesso;
        }

        public int IdTipoAcesso { get; set; }

        public string? DescricaoTipoAcesso { get; set; }


    }
}
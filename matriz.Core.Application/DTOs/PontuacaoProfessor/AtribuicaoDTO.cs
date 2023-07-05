using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class AtribuicaoDTO
    {
        public AtribuicaoDTO(int id, string descricao, string nomenclatura, string titulo)
        {
            Id = id;
            Descricao = descricao;
            Nomenclatura = nomenclatura;
            Titulo = titulo;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; } = string.Empty;
        public string Nomenclatura { get; private set; } = string.Empty;
        public string Titulo { get; private set; } = string.Empty;


    }
}

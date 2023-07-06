using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class DisciplinaDTO
    {
        public DisciplinaDTO(int id, int codigo, string nome, string sigla)
        {
            Id = id;
            Codigo = codigo;
            Nome = nome;
            Sigla = sigla;
        }

        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sigla { get; set; } = string.Empty;

    }
}

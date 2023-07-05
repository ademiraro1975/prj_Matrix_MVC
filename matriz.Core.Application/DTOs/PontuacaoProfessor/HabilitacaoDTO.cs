using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class HabilitacaoDTO
    {

        public int Id { get; private set; }
        public string Descricao { get; private set; } = string.Empty;

        public ICollection<CursoHabilitacaoDTO> CursoHabilitacaos { get; } = new List<CursoHabilitacaoDTO>();
        public ICollection<CursoDTO> Cursos { get; } = new List<CursoDTO>();
        public HabilitacaoDTO()
        {
            CursoHabilitacaos = new HashSet<CursoHabilitacaoDTO>();
            Cursos = new HashSet<CursoDTO>();
        }

    }
}

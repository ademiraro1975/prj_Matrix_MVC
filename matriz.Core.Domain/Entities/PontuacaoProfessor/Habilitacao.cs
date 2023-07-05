using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Habilitacao
    {

        public int Id { get; private set; }
        public string Descricao { get; private set; } = string.Empty;

        public ICollection<CursoHabilitacao> CursoHabilitacaos { get; } = new List<CursoHabilitacao>();
        public ICollection<Curso> Cursos { get; } = new List<Curso>();
        public Habilitacao()
        {
            CursoHabilitacaos = new HashSet<CursoHabilitacao>();
            Cursos = new HashSet<Curso>();
        }

    }
}

using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class HabilitacaoConfigurarion
    {

        public int Id { get; private set; }
        public string Descricao { get; private set; } = string.Empty;

        public ICollection<CursoHabilitacaoConfigurarion> CursoHabilitacaos { get; } = new List<CursoHabilitacaoConfigurarion>();
        public ICollection<CursoConfigurarion> Cursos { get; } = new List<CursoConfigurarion>();
        public HabilitacaoConfigurarion()
        {
            CursoHabilitacaos = new HashSet<CursoHabilitacaoConfigurarion>();
            Cursos = new HashSet<CursoConfigurarion>();
        }

    }
}

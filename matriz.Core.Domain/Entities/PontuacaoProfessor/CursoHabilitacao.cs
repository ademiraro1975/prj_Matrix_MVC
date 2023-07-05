using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CursoHabilitacao
    {
        public int Id { get;private set; }
        public int? Ordem { get;private set; }
        public int CursoId { get; private set; }
        public int HabilitacaoId { get; private set; }
        public  Curso Curso { get; } = new Curso();
        public  Habilitacao Habilitacao { get; } = new Habilitacao();
    }
}

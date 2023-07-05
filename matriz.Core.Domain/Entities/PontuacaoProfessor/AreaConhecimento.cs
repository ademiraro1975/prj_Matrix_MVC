using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class AreaConhecimento
    {


        public int Id { get; private set; }
        public string Descricao { get; private set; } = string.Empty;

        public  ICollection<CursoArea> CursoAreas { get;} = new List<CursoArea>();

        public AreaConhecimento()
        {
            CursoAreas = new HashSet<CursoArea>();
        }
    }
}

using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Periodo
    {

        public int Id { get; private set; }
        public DateTime HoraFim { get; private set; }
        public DateTime HoraInicio { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string Sigla { get; private set; } = string.Empty;


        public ICollection<Classe> Classes { get; } = new List<Classe>();
        public  ICollection<CursoUnidadePeriodo> CursoUnidadePeriodos { get; } = new List<CursoUnidadePeriodo>();
        public Periodo()
        {
            Classes = new HashSet<Classe>();
            CursoUnidadePeriodos = new HashSet<CursoUnidadePeriodo>();
        }


    }
}

using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class PeriodoConfigurarion
    {

        public int Id { get; private set; }
        public DateTime HoraFim { get; private set; }
        public DateTime HoraInicio { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string Sigla { get; private set; } = string.Empty;


        public ICollection<ClasseConfigurarion> Classes { get; } = new List<ClasseConfigurarion>();
        public  ICollection<CursoUnidadePeriodoConfigurarion> CursoUnidadePeriodos { get; } = new List<CursoUnidadePeriodoConfigurarion>();
        public PeriodoConfigurarion()
        {
            Classes = new HashSet<ClasseConfigurarion>();
            CursoUnidadePeriodos = new HashSet<CursoUnidadePeriodoConfigurarion>();
        }


    }
}

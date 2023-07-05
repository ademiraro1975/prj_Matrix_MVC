using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Modalidade
    {

        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public bool Modular { get; set; } = false;
        public string Nome { get; set; } = string.Empty;
        public string Nomenclatura { get; set; } = string.Empty;

        public ICollection<Curso> Cursos { get; } = new List<Curso>();  
        //public ICollection<AnoLetivoParametro> AnoLetivoParametros { get; } = new List<AnoLetivoParametro>();
        //public ICollection<DetalheModalidade> DetalheModalidades { get; } = new List<DetalheModalidade>();
        public Modalidade()
        {
            Cursos = new HashSet<Curso>();
            //AnoLetivoParametros = new HashSet<AnoLetivoParametro>();
            //DetalheModalidades = new HashSet<DetalheModalidade>();
        }
        
    }
}

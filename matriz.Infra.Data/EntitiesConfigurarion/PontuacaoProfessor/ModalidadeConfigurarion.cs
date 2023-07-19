using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class ModalidadeConfigurarion
    {

        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public bool Modular { get; set; } = false;
        public string Nome { get; set; } = string.Empty;
        public string Nomenclatura { get; set; } = string.Empty;

        public ICollection<CursoConfigurarion> Cursos { get; } = new List<CursoConfigurarion>();  
        //public ICollection<AnoLetivoParametro> AnoLetivoParametros { get; } = new List<AnoLetivoParametro>();
        //public ICollection<DetalheModalidade> DetalheModalidades { get; } = new List<DetalheModalidade>();
        public ModalidadeConfigurarion()
        {
            Cursos = new HashSet<CursoConfigurarion>();
            //AnoLetivoParametros = new HashSet<AnoLetivoParametro>();
            //DetalheModalidades = new HashSet<DetalheModalidade>();
        }
        
    }
}

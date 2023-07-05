using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class ModalidadeDTO
    {

        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public bool Modular { get; set; } = false;
        public string Nome { get; set; } = string.Empty;
        public string Nomenclatura { get; set; } = string.Empty;

        public ICollection<CursoDTO> Cursos { get; } = new List<CursoDTO>();  
        //public ICollection<AnoLetivoParametro> AnoLetivoParametros { get; } = new List<AnoLetivoParametro>();
        //public ICollection<DetalheModalidade> DetalheModalidades { get; } = new List<DetalheModalidade>();
        public ModalidadeDTO()
        {
            Cursos = new HashSet<CursoDTO>();
            //AnoLetivoParametros = new HashSet<AnoLetivoParametro>();
            //DetalheModalidades = new HashSet<DetalheModalidade>();
        }
        
    }
}

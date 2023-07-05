using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Cargo
    {

        public int Id { get;private set; }
        public string? Nomenclatura { get;private set; } = string.Empty;
        public string Titulo { get; private set; } = string.Empty;

        public ICollection<CargoDepartamentoUnidade> CargoDepartamentoUnidades { get; } = new List<CargoDepartamentoUnidade>(); 
        public Cargo()
        {
            CargoDepartamentoUnidades = new HashSet<CargoDepartamentoUnidade>();
        }    
    
    }
}

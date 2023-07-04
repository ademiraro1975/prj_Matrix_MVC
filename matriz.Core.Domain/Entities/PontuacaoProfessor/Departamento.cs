using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Departamento
    {

        public int Id { get; set; }
        public string Nome { get; private set; } = string.Empty;
        public string Nomenclatura { get; private set; } = string.Empty;


        public ICollection<DepartamentoUnidade> DepartamentoUnidades { get;} = new List<DepartamentoUnidade>();
        public Departamento()
        {
            DepartamentoUnidades = new HashSet<DepartamentoUnidade>();
        }    
    
    }
}

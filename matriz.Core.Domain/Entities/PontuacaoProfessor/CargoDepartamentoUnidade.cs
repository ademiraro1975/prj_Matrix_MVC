using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CargoDepartamentoUnidade
    {

        public int Id { get; private set; }

        public int CargoID { get; private set; }
        public int DepartamentoUnidadeId { get; private set; }

        public Cargo Cargo { get; } = new Cargo();
        public DepartamentoUnidade DepartamentoUnidade { get; } = new DepartamentoUnidade();

        public ICollection<FuncionarioCargoDepartamentoUnidade> FuncionarioCargoDepartamentoUnidades { get; } = new List<FuncionarioCargoDepartamentoUnidade>();   
        public CargoDepartamentoUnidade()
        {
            FuncionarioCargoDepartamentoUnidades = new HashSet<FuncionarioCargoDepartamentoUnidade>();
        }


    }
}

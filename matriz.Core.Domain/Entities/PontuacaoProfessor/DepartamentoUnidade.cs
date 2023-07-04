using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class DepartamentoUnidade
    {

        public int Id { get; private set; }
        public int DepartamentoId { get; private set; }
        public int UnidadeId { get; private set; }

        public Departamento Departamento { get; } = new Departamento();
        public Unidade Unidade { get; } = new Unidade();

        public ICollection<CargoDepartamentoUnidade> CargoDepartamentoUnidades { get; } = new List<CargoDepartamentoUnidade>();
        public DepartamentoUnidade()
        {
            CargoDepartamentoUnidades = new HashSet<CargoDepartamentoUnidade>();
        }

    }
}

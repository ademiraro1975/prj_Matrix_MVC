using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Atribuicao
    {


        public int Id { get; private set; }
        public string Descricao { get; private set; } = string.Empty;
        public string Nomenclatura { get; private set; } = string.Empty;
        public string Titulo { get; private set; } = string.Empty;

        public ICollection<FuncionarioCargoDepartamentoUnidade> FuncionarioCargoDepartamentoUnidades { get; } = new List<FuncionarioCargoDepartamentoUnidade>();
        public Atribuicao()
        {
            FuncionarioCargoDepartamentoUnidades = new HashSet<FuncionarioCargoDepartamentoUnidade>();
        }
    
    }
}

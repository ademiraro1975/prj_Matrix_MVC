using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class ProfessorConfigurarion
    {

        public int Id { get; private set; }
        public string Atribuicao { get;private set; } = string.Empty;
        public string Observacao { get; private set; } = string.Empty;
        public long RegistroDocente { get; private set; }

        public int FuncionarioCargoDepartamentoUnidadeId { get; private set; }

        public FuncionarioCargoDepartamentoUnidadeConfigurarion FuncionarioCargoDepartamentoUnidade { get;} = new FuncionarioCargoDepartamentoUnidadeConfigurarion(); 
        

    }
}

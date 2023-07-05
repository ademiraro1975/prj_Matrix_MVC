using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class ProfessorDTO
    {

        public int Id { get; private set; }
        public string Atribuicao { get;private set; } = string.Empty;
        public string Observacao { get; private set; } = string.Empty;
        public long RegistroDocente { get; private set; }

        public int FuncionarioCargoDepartamentoUnidadeId { get; private set; }

        public FuncionarioCargoDepartamentoUnidadeDTO FuncionarioCargoDepartamentoUnidade { get;} = new FuncionarioCargoDepartamentoUnidadeDTO(); 
        

    }
}

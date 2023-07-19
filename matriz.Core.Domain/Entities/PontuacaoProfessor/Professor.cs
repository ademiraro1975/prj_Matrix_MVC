using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Professor
    {

        public int Id { get; private set; }
        public string Atribuicao { get;private set; } = string.Empty;
        public string Observacao { get; private set; } = string.Empty;
        public long RegistroDocente { get; private set; }

        public int FuncionarioCargoDepartamentoUnidadeId { get; private set; }

        public FuncionarioCargoDepartamentoUnidade FuncionarioCargoDepartamentoUnidade { get;} = new FuncionarioCargoDepartamentoUnidade();

        public ICollection<Pontuacao> Pontuacao { get; } = new List<Pontuacao>();
        public Professor()
        {
            Pontuacao = new HashSet<Pontuacao>();
        }

    }
}

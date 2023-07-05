using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class Pontuacao
    {
        public int IdPontuacao { get; private set; }

        public int IdProcessoAtribuicao { get; private set; }

        public int IdProfessor { get; private set; }

        public decimal PontuacaoEscolaPont { get; private set; }

        public decimal PontuacaoFiebPont { get; private set; }

        public decimal DeducoesPont { get; private set; }

        public decimal TituloPont { get; private set; }

        public ProcessoAtribuicao ProcessoAtribuicao { get; } = new ProcessoAtribuicao();
        public Professor Professor { get; } = new Professor();

        public ICollection<DetalhePontuacao> DetalhePontuacao { get; } = new List<DetalhePontuacao>();
        public Pontuacao()
        {
            DetalhePontuacao = new HashSet<DetalhePontuacao>();
        }

    }
}
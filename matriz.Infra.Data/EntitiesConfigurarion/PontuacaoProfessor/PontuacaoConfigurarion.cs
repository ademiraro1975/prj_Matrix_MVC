using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class PontuacaoConfigurarion
    {
        public int IdPontuacao { get; private set; }

        public int IdProcessoAtribuicao { get; private set; }

        public int IdProfessor { get; private set; }

        public decimal PontuacaoEscolaPont { get; private set; }

        public decimal PontuacaoFiebPont { get; private set; }

        public decimal DeducoesPont { get; private set; }

        public decimal TituloPont { get; private set; }

        public ProcessoAtribuicaoConfigurarion ProcessoAtribuicao { get; } = new ProcessoAtribuicaoConfigurarion();
        public ProfessorConfigurarion Professor { get; } = new ProfessorConfigurarion();

        public ICollection<DetalhePontuacaoConfigurarion> DetalhePontuacao { get; } = new List<DetalhePontuacaoConfigurarion>();
        public PontuacaoConfigurarion()
        {
            DetalhePontuacao = new HashSet<DetalhePontuacaoConfigurarion>();
        }

    }
}
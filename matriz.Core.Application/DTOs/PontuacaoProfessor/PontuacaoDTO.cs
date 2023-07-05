using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class PontuacaoDTO
    {
        public int IdPontuacao { get; private set; }

        public int IdProcessoAtribuicao { get; private set; }

        public int IdProfessor { get; private set; }

        public decimal PontuacaoEscolaPont { get; private set; }

        public decimal PontuacaoFiebPont { get; private set; }

        public decimal DeducoesPont { get; private set; }

        public decimal TituloPont { get; private set; }

        public ProcessoAtribuicaoDTO ProcessoAtribuicao { get; } = new ProcessoAtribuicaoDTO();
        public ProfessorDTO Professor { get; } = new ProfessorDTO();

        public ICollection<DetalhePontuacaoDTO> DetalhePontuacao { get; } = new List<DetalhePontuacaoDTO>();
        public PontuacaoDTO()
        {
            DetalhePontuacao = new HashSet<DetalhePontuacaoDTO>();
        }

    }
}
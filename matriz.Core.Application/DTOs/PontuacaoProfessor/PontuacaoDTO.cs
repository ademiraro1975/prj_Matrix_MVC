using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class PontuacaoDTO
    {
        public PontuacaoDTO(int idPontuacao, int idProcessoAtribuicao, int idProfessor, decimal pontuacaoEscolaPont, decimal pontuacaoFiebPont, decimal deducoesPont, decimal tituloPont)
        {
            IdPontuacao = idPontuacao;
            IdProcessoAtribuicao = idProcessoAtribuicao;
            IdProfessor = idProfessor;
            PontuacaoEscolaPont = pontuacaoEscolaPont;
            PontuacaoFiebPont = pontuacaoFiebPont;
            DeducoesPont = deducoesPont;
            TituloPont = tituloPont;
        }

        public int IdPontuacao { get; private set; }

        public int IdProcessoAtribuicao { get; private set; }

        public int IdProfessor { get; private set; }

        public decimal PontuacaoEscolaPont { get; private set; }

        public decimal PontuacaoFiebPont { get; private set; }

        public decimal DeducoesPont { get; private set; }

        public decimal TituloPont { get; private set; }



    }
}
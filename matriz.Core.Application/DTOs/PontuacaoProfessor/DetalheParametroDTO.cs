using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class DetalheParametroDTO
    {
        public DetalheParametroDTO(int idDetalheParametro, int idParametro, int idProcessoAtribuicao, int idOperacaoParametro, int idUnidadeParametro, DateTime dataAlteracaoParam, decimal valorParam, decimal limiteParam, string unidadeParam)
        {
            IdDetalheParametro = idDetalheParametro;
            IdParametro = idParametro;
            IdProcessoAtribuicao = idProcessoAtribuicao;
            IdOperacaoParametro = idOperacaoParametro;
            IdUnidadeParametro = idUnidadeParametro;
            DataAlteracaoParam = dataAlteracaoParam;
            ValorParam = valorParam;
            LimiteParam = limiteParam;
            UnidadeParam = unidadeParam;
        }

        public int IdDetalheParametro { get; set; }
        public int IdParametro { get; set; }

        public int IdProcessoAtribuicao { get; set; }

        public int IdOperacaoParametro { get; set; }

        public int IdUnidadeParametro { get; set; }

        public DateTime DataAlteracaoParam { get; set; }

        public decimal ValorParam { get; set; }

        public decimal LimiteParam { get; set; }

        public string UnidadeParam { get; set; }

        
    }
}
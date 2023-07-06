using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class ProcessoAtribuicaoDTO
    {
        public ProcessoAtribuicaoDTO(int idProcessoAtribuicao, string descricao, DateTime dataInicio, DateTime dataFim, string portaria, string observacoes, string ativo)
        {
            IdProcessoAtribuicao = idProcessoAtribuicao;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Portaria = portaria;
            Observacoes = observacoes;
            Ativo = ativo;
        }

        public int IdProcessoAtribuicao { get; private set; }

        public string Descricao { get; private set; } = string.Empty;

        public DateTime DataInicio { get; private set; }

        public DateTime DataFim { get; private set; }

        public string Portaria { get; private set; } = string.Empty;

        public string Observacoes { get; private set; } = string.Empty;

        public string Ativo { get; private set; } = string.Empty;



    }
}
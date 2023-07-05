using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CursoDTO
{
        public CursoDTO(int id, string atribuicao, string codigo, string fundlegal, string nome, string perfilprofissional, int quantidadeniveis, int modalidadeId, int habilitacaoId, int periodoId)
        {
            Id = id;
            Atribuicao = atribuicao;
            Codigo = codigo;
            Fundlegal = fundlegal;
            Nome = nome;
            Perfilprofissional = perfilprofissional;
            Quantidadeniveis = quantidadeniveis;
            ModalidadeId = modalidadeId;
            HabilitacaoId = habilitacaoId;
            PeriodoId = periodoId;
        }

        public int Id { get; private set; }

        public string Atribuicao { get; private set; } = string.Empty;
        public string Codigo { get; private set; } = string.Empty;
        public string Fundlegal { get; private set; } = string.Empty;
        public string Nome { get; private set; } = string.Empty;
        public string Perfilprofissional { get; private set; } = string.Empty;
        public int Quantidadeniveis { get; private set; }
        public int ModalidadeId { get; private set; }
        public int HabilitacaoId { get; private set; }
        public int PeriodoId { get; private set; }    

    }
}

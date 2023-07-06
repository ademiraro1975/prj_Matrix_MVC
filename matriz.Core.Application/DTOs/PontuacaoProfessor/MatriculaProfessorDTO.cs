using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class MatriculaProfessorDTO
    {
        public MatriculaProfessorDTO(int idmatriculaprofessor, int idprofessor, int idcursoarea, string situacaoFuncional, string cargo, string formacao, DateTime? dataAdmissao, string listaClassificacaoUnidade, string listaClassificacaoGeral, DateTime dataAdmissaoFieb, string? cursoAreaFieb)
        {
            this.idmatriculaprofessor = idmatriculaprofessor;
            this.idprofessor = idprofessor;
            this.idcursoarea = idcursoarea;
            SituacaoFuncional = situacaoFuncional;
            Cargo = cargo;
            Formacao = formacao;
            DataAdmissao = dataAdmissao;
            ListaClassificacaoUnidade = listaClassificacaoUnidade;
            ListaClassificacaoGeral = listaClassificacaoGeral;
            DataAdmissaoFieb = dataAdmissaoFieb;
            CursoAreaFieb = cursoAreaFieb;
        }

        public int idmatriculaprofessor { get; private set; }
        public int idprofessor { get; private set; }
        public int idcursoarea { get; private set; }
        public string SituacaoFuncional { get; private set; } = string.Empty;
        public string Cargo { get; private set; } = string.Empty;
        public string Formacao { get; private set; } = string.Empty;
        public DateTime? DataAdmissao { get; private set; }
        public string ListaClassificacaoUnidade { get; private set; } = string.Empty;
        public string ListaClassificacaoGeral { get; private set; } = string.Empty;
        public DateTime DataAdmissaoFieb { get; private set; }
        public string? CursoAreaFieb { get; private set; } = string.Empty;



    }
}
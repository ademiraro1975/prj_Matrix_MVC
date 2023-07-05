using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class MatriculaProfessor
    {
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

        public CursoArea cargo { get; } = new CursoArea();
        public Professor Professor { get; } = new Professor();



    }
}
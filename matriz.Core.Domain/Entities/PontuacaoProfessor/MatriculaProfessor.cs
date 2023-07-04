using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class MatriculaProfessor
    {
        public int MatriculaProfessor { get; set; }

        public string? Cpf { get; set; }

        public int? IdUnidade { get; set; }

        public int? IdCursoArea { get; set; }

        public string? SituacaoFuncional { get; set; }

        public string? Cargo { get; set; }

        public string? Formacao { get; set; }

        public DateTime? DataAdmissao { get; set; }

        public string? ListaClassificacaoUnid { get; set; }

        public string? ListaClassificacaoGeral { get; set; }

        public DateTime? DataAdmissaoFieb { get; set; }

        public string? CursoAreaFieb { get; set; }
    }
}
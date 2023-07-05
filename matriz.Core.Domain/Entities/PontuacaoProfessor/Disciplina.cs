using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Disciplina
    {

        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sigla { get; set; } = string.Empty;

        public ICollection<CursoDisciplina> CursoDisciplinas { get; set; } = new List<CursoDisciplina>();
        //public ICollection<HistoricoDisciplina> HistoricoDisciplinas { get; set; } = new List<HistoricoDisciplina>();
        public Disciplina()
        {
            CursoDisciplinas = new HashSet<CursoDisciplina>();
            //HistoricoDisciplinas = new HashSet<HistoricoDisciplina>();

        }

    }
}

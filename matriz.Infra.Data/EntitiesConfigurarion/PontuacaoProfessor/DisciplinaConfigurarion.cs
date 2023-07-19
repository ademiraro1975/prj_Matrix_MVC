using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class DisciplinaConfigurarion
    {

        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sigla { get; set; } = string.Empty;

        public ICollection<CursoDisciplinaConfigurarion> CursoDisciplinas { get; set; } = new List<CursoDisciplinaConfigurarion>();
        //public ICollection<HistoricoDisciplina> HistoricoDisciplinas { get; set; } = new List<HistoricoDisciplina>();
        public DisciplinaConfigurarion()
        {
            CursoDisciplinas = new HashSet<CursoDisciplinaConfigurarion>();
            //HistoricoDisciplinas = new HashSet<HistoricoDisciplina>();

        }

    }
}

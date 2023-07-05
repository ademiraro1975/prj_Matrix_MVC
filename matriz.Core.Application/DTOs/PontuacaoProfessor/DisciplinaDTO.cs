using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class DisciplinaDTO
    {

        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sigla { get; set; } = string.Empty;

        public ICollection<CursoDisciplinaDTO> CursoDisciplinas { get; set; } = new List<CursoDisciplinaDTO>();
        //public ICollection<HistoricoDisciplina> HistoricoDisciplinas { get; set; } = new List<HistoricoDisciplina>();
        public DisciplinaDTO()
        {
            CursoDisciplinas = new HashSet<CursoDisciplinaDTO>();
            //HistoricoDisciplinas = new HashSet<HistoricoDisciplina>();

        }

    }
}

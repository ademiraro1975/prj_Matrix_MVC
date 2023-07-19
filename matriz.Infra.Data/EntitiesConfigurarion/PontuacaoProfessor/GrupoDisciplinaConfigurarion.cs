using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class GrupoDisciplinaConfigurarion
    {

        public int Id { get; private set; }
        public string Descricao { get; private set; } = string.Empty;
        public string Tipo { get; private set; } = string.Empty;

        //public  ICollection<CursoDisciplinaCargaHoraria> CursoDisciplinaCargaHorarias { get; } = new List<CursoDisciplinaCargaHoraria>();
        public ICollection<ClasseGrupoDisciplinaConfigurarion> ClasseGrupoDisciplinas { get; } = new List<ClasseGrupoDisciplinaConfigurarion>();

        public GrupoDisciplinaConfigurarion()
        {
            //CursoDisciplinaCargaHorarias = new HashSet<CursoDisciplinaCargaHoraria>();
            ClasseGrupoDisciplinas = new HashSet<ClasseGrupoDisciplinaConfigurarion>();
        }    
    
    }
}

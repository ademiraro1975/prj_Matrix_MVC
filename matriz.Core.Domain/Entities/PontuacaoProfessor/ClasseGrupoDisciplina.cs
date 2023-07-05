using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class ClasseGrupoDisciplina
    {

        public int Id { get; private set; }
        public int ClasseId { get; private set; }
        public int GrupoDisciplinaId { get; private set; }

        public Classe Classe { get; } = new Classe();
        public GrupoDisciplina GrupoDisciplina { get; } = new GrupoDisciplina();

    }
}

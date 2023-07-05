using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class ClasseGrupoDisciplinaDTO
    {
        public ClasseGrupoDisciplinaDTO(int id, int classeId, int grupoDisciplinaId)
        {
            Id = id;
            ClasseId = classeId;
            GrupoDisciplinaId = grupoDisciplinaId;
        }

        public int Id { get; private set; }
        public int ClasseId { get; private set; }
        public int GrupoDisciplinaId { get; private set; }


    }
}

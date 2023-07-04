using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Rotina
    {


        public int Id { get;private set; }

        public string Descricao { get;private set; } = string.Empty;
        public int Menuordem { get; private set; }
        public string Nomenclatura { get; private set; } = string.Empty;
        public int Prioridade { get; private set; }

        public int SistemaId { get; private set; }

        public Sistema Sistema { get; } = new Sistema();

        public ICollection<RotinaOperacao> RotinaOperacaos { get; }
        public Rotina()
        {
            RotinaOperacaos = new HashSet<RotinaOperacao>();
        }
    }
}

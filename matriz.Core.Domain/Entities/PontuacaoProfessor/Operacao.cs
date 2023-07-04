using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Operacao
    {

        public int Id { get; private set; }
        public string Descricao { get; private set; } = string.Empty;
        public string Nomenclatura { get; private set; } = string.Empty;

        public ICollection<RotinaOperacao> RotinaOperacaos { get; } = new List<RotinaOperacao>();
        public Operacao()
        {
            RotinaOperacaos = new HashSet<RotinaOperacao>();
        }
    }
}

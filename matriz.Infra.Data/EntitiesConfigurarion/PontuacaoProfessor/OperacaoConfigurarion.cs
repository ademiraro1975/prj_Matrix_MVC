using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class OperacaoConfigurarion
    {

        public int Id { get; private set; }
        public string Descricao { get; private set; } = string.Empty;
        public string Nomenclatura { get; private set; } = string.Empty;

        public ICollection<RotinaOperacaoConfigurarion> RotinaOperacaos { get; } = new List<RotinaOperacaoConfigurarion>();
        public OperacaoConfigurarion()
        {
            RotinaOperacaos = new HashSet<RotinaOperacaoConfigurarion>();
        }
    }
}

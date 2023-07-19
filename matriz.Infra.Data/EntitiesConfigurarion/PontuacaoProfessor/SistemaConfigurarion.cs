using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class SistemaConfigurarion
    {

        public int Id { get;private set; }
        public string Descricao { get;private set; } = string.Empty;
        public string Nomenclatura { get; private set; } = string.Empty;

        public ICollection<LogSistemaConfigurarion> LogSistemas { get; } = new List<LogSistemaConfigurarion>();
        public ICollection<RotinaConfigurarion> Rotinas { get; } = new List<RotinaConfigurarion>();
        public SistemaConfigurarion()
        {
            LogSistemas = new HashSet<LogSistemaConfigurarion>();
            Rotinas = new HashSet<RotinaConfigurarion>();
        }
    }
}

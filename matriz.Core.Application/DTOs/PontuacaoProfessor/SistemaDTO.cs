using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class SistemaDTO
    {

        public int Id { get;private set; }
        public string Descricao { get;private set; } = string.Empty;
        public string Nomenclatura { get; private set; } = string.Empty;

        public ICollection<LogSistemaDTO> LogSistemas { get; } = new List<LogSistemaDTO>();
        public ICollection<RotinaDTO> Rotinas { get; } = new List<RotinaDTO>();
        public SistemaDTO()
        {
            LogSistemas = new HashSet<LogSistemaDTO>();
            Rotinas = new HashSet<RotinaDTO>();
        }
    }
}

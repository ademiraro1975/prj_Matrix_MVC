using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class Auditoria
    {
        public int IdAuditoria { get; set; }

        public int? IdUsuario { get; set; }

        public string? Browser { get; set; }

        public string? Ip { get; set; }

        public DateTime DataHora { get; set; }

        public string? Detalhes { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public partial class ProcessoAtrib
    {
        public int CodigoProcessoAtrib { get; set; }

        public string? DescricaoProcessoAtrib { get; set; }

        public DateTime? DataInicioProcessoAtrib { get; set; }

        public DateTime? DataFimProcessoAtrib { get; set; }

        public string? PortariaProcessoAtrib { get; set; }

        public string? ObservacoesProcessoAtrib { get; set; }

        public string? Ativo { get; set; }

        public virtual ICollection<DetParam> TblDetParams { get; } = new List<DetParam>();
    }
}
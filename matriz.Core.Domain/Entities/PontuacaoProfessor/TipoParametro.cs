using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class TipoParametro
    {
        public int IdTipoParametro { get; private set; }

        public string DescricaoTipoAcesso { get; private set; } = string.Empty;

        public string Abreviacao { get; private set; } = string.Empty;

        public ICollection<Parametro> Parametro { get; } = new List<Parametro>();

        public TipoParametro()
        {
            Parametro = new HashSet<Parametro>();
        }
    }
}
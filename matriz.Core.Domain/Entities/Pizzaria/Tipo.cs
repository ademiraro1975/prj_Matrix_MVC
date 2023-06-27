using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.Pizzaria
{
    public sealed class Tipo
    {
        public int TipoId { get; private set; }

        public string Descricao { get; private set; } = string.Empty;

        public ICollection<PizzaDetalhe> PizzaDetalhes { get; } = new List<PizzaDetalhe>();
        public ICollection<RefrigeranteDetalhe> RefrigeranteDetalhes { get; } = new List<RefrigeranteDetalhe>();

        public Tipo()
        {
            PizzaDetalhes = new HashSet<PizzaDetalhe>();
            RefrigeranteDetalhes = new HashSet<RefrigeranteDetalhe>();
        }

        public Tipo(int tipoId, string descricao)
        {
            TipoId = tipoId;
            Descricao = descricao;
        }

        public Tipo(string descricao)
        {
            Descricao = descricao;
        }
    }
}
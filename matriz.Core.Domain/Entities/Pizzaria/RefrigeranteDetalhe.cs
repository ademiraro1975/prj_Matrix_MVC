using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.Pizzaria
{

    public sealed class RefrigeranteDetalhe
    {
        public int RefrigeranteDetalheId { get; private set; }

        public int RefrigeranteId { get; private set; }

        public int TabelaPrecoId { get; private set; }

        public int TamanhoId { get; private set; }

        public int TipoId { get; private set; }

        public Refrigerante Refrigerante { get; } = new Refrigerante();

        public TabelaPreco TabelaPreco { get; } = new TabelaPreco();

        public Tamanho Tamanho { get; } = new Tamanho();

        public Tipo Tipo { get; } = new Tipo();
    }
}
using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.Pizzaria
{

    public sealed class Refrigerante
    {
        public int RefrigeranteId { get; private set; }

        public string Nome { get; private set; } = string.Empty;

        public string Descricao { get; private set; } = string.Empty;

        public ICollection<FotoRefrigerante> FotoRefrigerantes { get; } = new List<FotoRefrigerante>();
        public ICollection<RefrigeranteDetalhe> RefrigeranteDetalhes { get; } = new List<RefrigeranteDetalhe>();

        public Refrigerante()
        {
            FotoRefrigerantes = new HashSet<FotoRefrigerante>();
            RefrigeranteDetalhes = new HashSet<RefrigeranteDetalhe>();
        }

        public Refrigerante(int refrigeranteId, string nome, string descricao)
        {
            RefrigeranteId = refrigeranteId;
            Nome = nome;
            Descricao = descricao;
        }

        public Refrigerante(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}
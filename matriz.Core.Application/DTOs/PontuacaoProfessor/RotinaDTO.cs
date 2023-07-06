using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class RotinaDTO
    {
        public RotinaDTO(int id, string descricao, int menuordem, string nomenclatura, int prioridade, int sistemaId)
        {
            Id = id;
            Descricao = descricao;
            Menuordem = menuordem;
            Nomenclatura = nomenclatura;
            Prioridade = prioridade;
            SistemaId = sistemaId;
        }

        public int Id { get;private set; }
        public string Descricao { get;private set; } = string.Empty;
        public int Menuordem { get; private set; }
        public string Nomenclatura { get; private set; } = string.Empty;
        public int Prioridade { get; private set; }
        public int SistemaId { get; private set; }

    }
}

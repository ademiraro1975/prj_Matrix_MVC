using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CargoDepartamentoUnidadeDTO
    {
        public CargoDepartamentoUnidadeDTO(int id, int cargoID, int departamentoUnidadeId)
        {
            Id = id;
            CargoID = cargoID;
            DepartamentoUnidadeId = departamentoUnidadeId;
        }

        public int Id { get; private set; }

        public int CargoID { get; private set; }
        public int DepartamentoUnidadeId { get; private set; }



    }
}

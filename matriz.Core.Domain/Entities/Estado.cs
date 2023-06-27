using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.Core.Domain.Entities
{
    public sealed class Estado
    {

        public int Id { get; private set; }
        public string Descricao { get; private set; } = string.Empty;
        public string Sigla { get; private set; } = string.Empty;

        public Estado(int id, string descricao, string sigla)
        {
            Id = id;
            Descricao = descricao;
            Sigla = sigla;
        }

    }
}

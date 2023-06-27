using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.Core.Application.DTOs
{
    public class EstadoDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public string Sigla { get; set; } = string.Empty;

    }
}

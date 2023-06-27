using matriz.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.Core.Application.Interfaces
{
    public interface IEstadoService
    {
        string ObterSiglaEstadoPorId(int estadoId);
        string ObterSiglaEstadoPorCidadeId(int cidadeId);
    }
}

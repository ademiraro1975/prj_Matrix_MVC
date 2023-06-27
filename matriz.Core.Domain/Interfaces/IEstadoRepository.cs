using matriz.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.Core.Domain.Interfaces
{
    public interface IEstadoRepository
    {
        string ObterSiglaEstadoPorId(int estadoId);
        string ObterSiglaEstadoPorCidadeId(int cidadeId);
    }
}

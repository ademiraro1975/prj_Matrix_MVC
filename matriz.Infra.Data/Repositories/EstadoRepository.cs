using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Interfaces;
using matriz.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.Infra.Data.Repositories
{
    public class EstadoRepository : IEstadoRepository
    {
        private readonly AppDbContext _appDbContext;

        public EstadoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string ObterSiglaEstadoPorId(int estadoId)
        {

            var estado = _appDbContext.Estados
                            .FromSqlRaw("dbo.pcdestado_slct_estadoid @estadoId", new SqlParameter("@estadoId", estadoId))
                            .AsEnumerable()
                            .Select(s => s.Sigla)
                            .FirstOrDefault();

            return estado ?? string.Empty;

        }

        public string ObterSiglaEstadoPorCidadeId(int cidadeId)
        {

            var estado = _appDbContext.Estados
                            .FromSqlRaw("dbo.pcdestado_slct_idcidade @idcidade", new SqlParameter("@idcidade", cidadeId))
                            .AsEnumerable()
                            .Select(s => s.Sigla)
                            .FirstOrDefault();

            return estado ?? string.Empty;

        }
    }
}

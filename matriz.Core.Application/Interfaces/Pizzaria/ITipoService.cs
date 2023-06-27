using matriz.Core.Application.DTOs;
using matriz.Core.Application.DTOs.Pizzaria;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Entities.Pizzaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.Core.Application.Interfaces
{
    public interface ITipoService
    {
        Task<IEnumerable<TipoDTO>> ObterListaTipoAsync();

        TipoDTO ObterTipoAsync(int tipoId);
        Task<TipoDTO> SalvarTipo(Tipo tipo);
        Task<TipoDTO> AlterarTipo(Tipo tipo);
        Task<TipoDTO> ExcluirTipo(int tipoId);

    }
}

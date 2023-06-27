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
    public interface ITamanhoService
    {
        Task<IEnumerable<TamanhoDTO>> ObterListaTamanhoAsync();

        TamanhoDTO ObterTamanhoAsync(int tamanhoId);
        Task<TamanhoDTO> SalvarTamanho(Tamanho tamanho);
        Task<TamanhoDTO> AlterarTamanho(Tamanho tamanho);
        Task<TamanhoDTO> ExcluirTamanho(int tamanhoId);

    }
}

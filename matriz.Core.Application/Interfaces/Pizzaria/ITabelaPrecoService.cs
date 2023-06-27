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
    public interface ITabelaPrecoService
    {
        Task<IEnumerable<TabelaPrecoDTO>> ObterListaTabelaPrecoAsync();

        TabelaPrecoDTO ObterTabelaPrecoAsync(int tabelaPrecoId);
        Task<TabelaPrecoDTO> SalvarTabelaPreco(TabelaPreco tabelPreco);
        Task<TabelaPrecoDTO> AlterarTabelaPreco(TabelaPreco tabelaPreco);
        Task<TabelaPrecoDTO> ExcluirTabelaPreco(int tabelaPrecoId);

    }
}

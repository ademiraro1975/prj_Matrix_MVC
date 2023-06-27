using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Entities.Pizzaria;

namespace matriz.Core.Domain.Interfaces;

public interface ITabelaPrecoRepository
{
    Task<IEnumerable<TabelaPreco>> ObterListaTabelaPrecoAsync();
    TabelaPreco ObterTabelaPrecoAsync(int Id);

    Task<TabelaPreco> SalvarTabelaPreco(TabelaPreco tabelaPreco);
    Task<TabelaPreco> AlterarTabelaPreco(TabelaPreco tabelaPreco);
    Task<TabelaPreco> ExcluirTabelaPreco(int tabelaPrecoId);

}

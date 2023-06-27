using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Entities.Pizzaria;

namespace matriz.Core.Domain.Interfaces;

public interface ITamanhoRepository
{
    Task<IEnumerable<Tamanho>> ObterListaTamanhoAsync();
    Tamanho ObterTamanhoAsync(int tamanhoId);

    Task<Tamanho> SalvarTamanho(Tamanho tamanho);
    Task<Tamanho> AlterarTamanho(Tamanho tamanho);
    Task<Tamanho> ExcluirTamanho(int tamanhoId);

}

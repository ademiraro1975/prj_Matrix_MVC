using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Entities.Pizzaria;

namespace matriz.Core.Domain.Interfaces;

public interface ITipoRepository
{
    Task<IEnumerable<Tipo>> ObterListaTipoAsync();
    Tipo ObterTipoAsync(int tipoId);

    Task<Tipo> SalvarTipo(Tipo tipo);
    Task<Tipo> AlterarTipo(Tipo tipo);
    Task<Tipo> ExcluirTipo(int tipoId);

}

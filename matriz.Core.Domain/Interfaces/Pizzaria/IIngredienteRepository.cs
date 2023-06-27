using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Entities.Pizzaria;

namespace matriz.Core.Domain.Interfaces;

public interface IIngredienteRepository
{
    Task<IEnumerable<Ingrediente>> ObterListaIngredienteAsync();
    Ingrediente ObterIngredienteAsync(int ingredienteId);

    Task<Ingrediente> SalvarIngrediente(Ingrediente ingrediente);
    Task<Ingrediente> AlterarIngrediente(Ingrediente ingrediente);
    Task<Ingrediente> ExcluirIngrediente(int ingredienteId);

}

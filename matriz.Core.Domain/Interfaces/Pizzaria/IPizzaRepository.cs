using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Entities.Pizzaria;

namespace matriz.Core.Domain.Interfaces;

public interface IPizzaRepository
{
    Task<IEnumerable<Pizza>> ObterListaPizzaAsync();
    Pizza ObterPizzaAsync(int pizzaId);

    Task<Pizza> SalvarPizza(Pizza pizza);
    Task<Pizza> AlterarPizza(Pizza pizza);
    Task<PizzaDetalhe> AdicionarPizzaDetalhe(PizzaDetalhe pizzaDetalhe);
    Task<Pizza> ExcluirPizza(int pizzaId);
    IEnumerable<FotoPizza> ObterFotoPizzaAsync(int pizzaId);

    IEnumerable<Ingrediente> ObterIngredientePizzaAsync(int pizzaId);

    IEnumerable<PizzaDetalhe> ObterPizzaDetalheAsync(int pizzaId);

    Task<FotoPizza> SalvarFotoPizza(FotoPizza fotoPizza);
    Task<PizzaIngrediente> SalvarPizzaIngrediente(PizzaIngrediente pizzaIngrediente);
    Task<FotoPizza> ExcluirFotoPizza(int fotoPizzaId);
    Task<PizzaIngrediente> ExcluirPizzaIngrediente(int pizzaId, int ingredienteId);
    Task<PizzaDetalhe> ExcluirPizzaDetalhe(int pizzaDetalheId);
}

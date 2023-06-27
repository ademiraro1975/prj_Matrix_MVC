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
    public interface IPizzaService
    {
        Task<IEnumerable<PizzaDTO>> ObterListaPizzaAsync();

        PizzaDTO ObterPizzaAsync(int pizzaId);
        Task<PizzaDTO> SalvarPizza(Pizza pizza);
        Task<PizzaDTO> AlterarPizza(Pizza pizza);
        Task<PizzaDetalheDTO> AdicionarPizzaDetalhe(PizzaDetalhe pizzaDetalhe);
        Task<PizzaDTO> ExcluirPizza(int pizzaId);
        IEnumerable<FotoPizzaDTO> ObterFotoPizzaAsync(int pizzaId);
        IEnumerable<IngredienteDTO> ObterIngredientePizzaAsync(int pizzaId);
        IEnumerable<PizzaDetalheDTO> ObterPizzaDetalheAsync(int pizzaId);
        Task<FotoPizzaDTO> SalvarFotoPizza(FotoPizza fotoPizza);
        Task<PizzaIngredienteDTO> SalvarPizzaIngrediente(PizzaIngrediente pizzaIngrediente);
        Task<FotoPizzaDTO> ExcluirFotoPizza(int fotoPizzaId);
        Task<PizzaIngredienteDTO> ExcluirPizzaIngrediente(int pizzaId, int ingredienteId);
        Task<PizzaDetalheDTO> ExcluirPizzaDetalhe(int pizzaDetalheId);
    }
}

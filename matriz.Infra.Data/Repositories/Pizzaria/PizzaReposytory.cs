using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Interfaces;
using matriz.Infra.Data.Context;
using matriz.Core.Domain.Entities.Pizzaria;

namespace matriz.Infra.Data.Repositories;

public class PizzaRepository : IPizzaRepository
{
    private readonly PizzariaContext _pizzariaContext;

    public PizzaRepository(PizzariaContext pizzariaContext)
    {
        _pizzariaContext = pizzariaContext;
    }

    public async Task<IEnumerable<Pizza>> ObterListaPizzaAsync()
    {
        var pizza = (
                            from piz in _pizzariaContext.Pizzas
                            join pfot in _pizzariaContext.FotoPizzas on piz.PizzaId equals pfot.FotoPizzaId
                            //where func.Email == email
                            orderby piz.Nome ascending
                            select new Pizza
                            (
                                 piz.PizzaId,
                                 piz.Nome, 
                                 piz.Descricao,
                                 pfot.Foto

                            )).ToListAsync();


        return await pizza;
    }

    public Pizza ObterPizzaAsync(int pizzaId)
    {
        var pizza = (
                             from piz in _pizzariaContext.Pizzas
                             where piz.PizzaId == pizzaId
                             orderby piz.Nome ascending
                             select new Pizza
                             (
                                  piz.PizzaId,
                                  piz.Nome,
                                  piz.Descricao
                             )).FirstOrDefault();


        return pizza;
    }

    public async Task<Pizza> SalvarPizza(Pizza pizza)
    {
        _pizzariaContext.Entry(pizza).State = EntityState.Modified;

        _pizzariaContext.Pizzas.Add(pizza);
        await _pizzariaContext.SaveChangesAsync();

        return pizza;
    }

    public async Task<Pizza> AlterarPizza(Pizza pizza)
    {
        _pizzariaContext.Entry(pizza).State = EntityState.Modified;

        _pizzariaContext.Pizzas.Update(pizza);
        await _pizzariaContext.SaveChangesAsync();

        return pizza;
    }

    public async Task<PizzaDetalhe> AdicionarPizzaDetalhe(PizzaDetalhe pizzaDetalhe)
    {
        _pizzariaContext.Entry(pizzaDetalhe).State = EntityState.Modified;

        _pizzariaContext.PizzaDetalhes.Add(pizzaDetalhe);
        await _pizzariaContext.SaveChangesAsync();

        return pizzaDetalhe;
    }


    public async Task<Pizza> ExcluirPizza(int pizzaId)
    {

        var pizza = await _pizzariaContext.Pizzas.FindAsync(pizzaId);
        if (pizza != null)
        {
            _pizzariaContext.Entry(pizza).State = EntityState.Deleted;
            _pizzariaContext.Pizzas.Remove(pizza);
        }
        await _pizzariaContext.SaveChangesAsync();
        return pizza;
    }

    public IEnumerable<FotoPizza> ObterFotoPizzaAsync(int pizzaId)
    {
        var fotoPizza = (
                            from fpiz in _pizzariaContext.FotoPizzas
                            where fpiz.PizzaId == pizzaId
                            orderby fpiz.PizzaId ascending
                            select new FotoPizza
                            (
                                 fpiz.FotoPizzaId,
                                 fpiz.PizzaId,
                                 fpiz.Foto

                            )).ToList();


        return fotoPizza;
    }

    public IEnumerable<Ingrediente> ObterIngredientePizzaAsync(int pizzaId)
    {
        var ingredientePizza = (
                            from ipiz in _pizzariaContext.PizzaIngredientes
                            join ingr in _pizzariaContext.Ingredientes on ipiz.IngredienteId equals ingr.IngredienteId
                            where ipiz.PizzaId == pizzaId
                            orderby ipiz.Ingrediente ascending
                            select new Ingrediente
                            (
                                ingr.IngredienteId,
                                ingr.Nome
                            )).ToList();


        return ingredientePizza;
    }

    public IEnumerable<PizzaDetalhe> ObterPizzaDetalheAsync(int pizzaId)
    {
        var pizzaDetalhe = (
                            from pizdet in _pizzariaContext.PizzaDetalhes
                            join tabpre in _pizzariaContext.TabelaPrecos on pizdet.TabelaPrecoId equals tabpre.TabelaPrecoId
                            join tam in _pizzariaContext.Tamanhos on pizdet.TamanhoId equals tam.TamanhoId
                            join tip in _pizzariaContext.Tipos on pizdet.TipoId equals tip.TipoId
                            where pizdet.PizzaId == pizzaId
                            orderby tam.Descricao ascending
                            select new PizzaDetalhe
                            (
                                pizdet.PizzaDetalheId,
                                pizdet.PizzaId,
                                pizdet.TabelaPrecoId,
                                pizdet.TamanhoId,
                                pizdet.TipoId,

                                pizdet.TabelaPreco.Preco.ToString(),
                                pizdet.Tamanho.Descricao,
                                pizdet.Tipo.Descricao   
                            )).ToList();

        return pizzaDetalhe;
    }

    public async Task<PizzaIngrediente> SalvarPizzaIngrediente(PizzaIngrediente pizzaIngrediente)
    {
        _pizzariaContext.Entry(pizzaIngrediente).State = EntityState.Modified;

        _pizzariaContext.PizzaIngredientes.Add(pizzaIngrediente);
        await _pizzariaContext.SaveChangesAsync();

        return pizzaIngrediente;
    }

    public async Task<FotoPizza> SalvarFotoPizza(FotoPizza fotoPizza)
    {
        _pizzariaContext.Entry(fotoPizza).State = EntityState.Modified;

        _pizzariaContext.FotoPizzas.Add(fotoPizza);
        await _pizzariaContext.SaveChangesAsync();

        return fotoPizza;
    }

    public async Task<FotoPizza> ExcluirFotoPizza(int fotoPizzaId)
    {

        var fotopizza = await _pizzariaContext.FotoPizzas.FindAsync(fotoPizzaId);
        if (fotopizza != null)
        {
            _pizzariaContext.Entry(fotopizza).State = EntityState.Deleted;
            _pizzariaContext.FotoPizzas.Remove(fotopizza);
        }
        await _pizzariaContext.SaveChangesAsync();
        return fotopizza;
    }


    public async Task<PizzaIngrediente> ExcluirPizzaIngrediente(int pizzaId, int ingredienteId)
    {
                var pizzaIngrediente = (
                            from ipiz in _pizzariaContext.PizzaIngredientes
                            where ipiz.PizzaId == pizzaId
                            where ipiz.IngredienteId == ingredienteId
                            select new PizzaIngrediente
                            (
                                ipiz.PizzaIngredienteId,
                                ipiz.PizzaId,
                                ipiz.IngredienteId
                            )).FirstOrDefault();

        if (pizzaIngrediente != null)
        {
            _pizzariaContext.Entry(pizzaIngrediente).State = EntityState.Deleted;
            _pizzariaContext.PizzaIngredientes.Remove(pizzaIngrediente);
        }

        await _pizzariaContext.SaveChangesAsync();

        return pizzaIngrediente;
    }

    public async Task<PizzaDetalhe> ExcluirPizzaDetalhe(int pizzaDetalheId)
    {
        var pizzaDetalhe = (
                    from ipiz in _pizzariaContext.PizzaDetalhes
                    where ipiz.PizzaDetalheId == pizzaDetalheId
                    select new PizzaDetalhe
                    (
                        ipiz.PizzaDetalheId,
                        ipiz.PizzaId,
                        ipiz.TabelaPrecoId,
                        ipiz.TamanhoId,
                        ipiz.TipoId
                    )).FirstOrDefault();

        if (pizzaDetalhe != null)
        {

            _pizzariaContext.Entry(pizzaDetalhe).State = EntityState.Deleted;
            _pizzariaContext.PizzaDetalhes.Remove(pizzaDetalhe);
        }
        await _pizzariaContext.SaveChangesAsync();

        return pizzaDetalhe;
    }
}

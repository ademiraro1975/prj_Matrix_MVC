using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Interfaces;
using matriz.Infra.Data.Context;
using matriz.Core.Domain.Entities.Pizzaria;

namespace matriz.Infra.Data.Repositories;

public class IngredienteRepository : IIngredienteRepository
{
    private readonly PizzariaContext _pizzariaContext;

    public IngredienteRepository(PizzariaContext pizzariaContext)
    {
        _pizzariaContext = pizzariaContext;
    }
    public async Task<IEnumerable<Ingrediente>> ObterListaIngredienteAsync()
    {
        var ingrediente = (
                            from ingr in _pizzariaContext.Ingredientes
                                //where func.Email == email
                            orderby ingr.Nome ascending
                            select new Ingrediente
                            (
                                 ingr.IngredienteId,
                                 ingr.Nome

                            )).ToListAsync();


        return await ingrediente;
    }

    public Ingrediente ObterIngredienteAsync(int ingredienteId)
    {
        var ingrediente = (
                             from ingr in _pizzariaContext.Ingredientes
                             where ingr.IngredienteId == ingredienteId
                             orderby ingr.Nome ascending
                             select new Ingrediente
                             (
                                  ingr.IngredienteId,
                                  ingr.Nome
                             )).FirstOrDefault();


        return ingrediente;
    }

    public async Task<Ingrediente> SalvarIngrediente(Ingrediente ingrediente)
    {
        _pizzariaContext.Entry(ingrediente).State = EntityState.Modified;

        _pizzariaContext.Ingredientes.Add(ingrediente);
        await _pizzariaContext.SaveChangesAsync();

        return ingrediente;
    }

    public async Task<Ingrediente> AlterarIngrediente(Ingrediente ingrediente)
    {
        _pizzariaContext.Entry(ingrediente).State = EntityState.Modified;

        _pizzariaContext.Ingredientes.Update(ingrediente);
        await _pizzariaContext.SaveChangesAsync();

        return ingrediente;
    }


    public async Task<Ingrediente> ExcluirIngrediente(int ingredienteId)
    {

        var ingrediente = await _pizzariaContext.Ingredientes.FindAsync(ingredienteId);
        if (ingrediente != null)
        {
            _pizzariaContext.Ingredientes.Remove(ingrediente);
        }
        await _pizzariaContext.SaveChangesAsync();

        return ingrediente;
    }
}

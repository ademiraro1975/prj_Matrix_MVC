using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Interfaces;
using matriz.Infra.Data.Context;
using matriz.Core.Domain.Entities.Pizzaria;

namespace matriz.Infra.Data.Repositories;

public class TipoRepository : ITipoRepository
{
    private readonly PizzariaContext _pizzariaContext;

    public TipoRepository(PizzariaContext pizzariaContext)
    {
        _pizzariaContext = pizzariaContext;
    }
    public async Task<IEnumerable<Tipo>> ObterListaTipoAsync()
    {
        var tipo = (
                            from tip in _pizzariaContext.Tipos
                                //where func.Email == email
                            orderby tip.Descricao ascending
                            select new Tipo
                            (
                                 tip.TipoId,
                                 tip.Descricao

                            )).ToListAsync();


        return await tipo;
    }

    public Tipo ObterTipoAsync(int ingredienteId)
    {
        var tipo = (
                             from tip in _pizzariaContext.Tipos
                             where tip.TipoId == ingredienteId
                             orderby tip.Descricao ascending
                             select new Tipo
                             (
                                  tip.TipoId,
                                  tip.Descricao
                             )).FirstOrDefault();


        return tipo;
    }

    public async Task<Tipo> SalvarTipo(Tipo tipo)
    {
        _pizzariaContext.Entry(tipo).State = EntityState.Modified;

        _pizzariaContext.Tipos.Add(tipo);
        await _pizzariaContext.SaveChangesAsync();

        return tipo;
    }

    public async Task<Tipo> AlterarTipo(Tipo tipo)
    {
        _pizzariaContext.Entry(tipo).State = EntityState.Modified;

        _pizzariaContext.Tipos.Update(tipo);
        await _pizzariaContext.SaveChangesAsync();

        return tipo;
    }


    public async Task<Tipo> ExcluirTipo(int tipoId)
    {

        var tipo = await _pizzariaContext.Tipos.FindAsync(tipoId);
        if (tipo != null)
        {
            _pizzariaContext.Tipos.Remove(tipo);
        }
        await _pizzariaContext.SaveChangesAsync();

        return tipo;
    }
}

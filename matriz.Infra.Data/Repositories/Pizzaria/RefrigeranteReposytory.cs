using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Interfaces;
using matriz.Infra.Data.Context;
using matriz.Core.Domain.Entities.Pizzaria;

namespace matriz.Infra.Data.Repositories;

public class RefrigeranteRepository : IRefrigeranteRepository
{
    private readonly PizzariaContext _pizzariaContext;

    public RefrigeranteRepository(PizzariaContext pizzariaContext)
    {
        _pizzariaContext = pizzariaContext;
    }
    public async Task<IEnumerable<Refrigerante>> ObterListaRefrigeranteAsync()
    {
        var refrigerante = (
                            from refri in _pizzariaContext.Refrigerantes
                                //where func.Email == email
                            orderby refri.Nome ascending
                            select new Refrigerante
                            (
                                 refri.RefrigeranteId,
                                 refri.Nome,
                                 refri.Descricao

                            )).ToListAsync();


        return await refrigerante;
    }
    public Refrigerante ObterRefrigeranteAsync(int refrigeranteId)
    {
        var refrigerante = (
                            from refr in _pizzariaContext.Refrigerantes
                            where refr.RefrigeranteId == refrigeranteId
                            orderby refr.Nome ascending
                            select new Refrigerante
                            (
                                 refr.RefrigeranteId,
                                 refr.Nome,
                                 refr.Descricao

                            )).FirstOrDefault();


        return refrigerante;
    }
    public async Task<Refrigerante> SalvarRefrigerante(Refrigerante refrigerante)
    {
        _pizzariaContext.Entry(refrigerante).State = EntityState.Modified;

        _pizzariaContext.Refrigerantes.Add(refrigerante);
        await _pizzariaContext.SaveChangesAsync();

        return refrigerante;
    }
    public async Task<Refrigerante> AlterarRefrigerante(Refrigerante refrigerante)
    {
        _pizzariaContext.Entry(refrigerante).State = EntityState.Modified;

        _pizzariaContext.Refrigerantes.Update(refrigerante);
        await _pizzariaContext.SaveChangesAsync();

        return refrigerante;
    }

    public async Task<Refrigerante> ExcluirRefrigerante(int refrigeranteId)
    {

        var refrigerante = await _pizzariaContext.Refrigerantes.FindAsync(refrigeranteId);
        if (refrigerante != null)
        {
            _pizzariaContext.Refrigerantes.Remove(refrigerante);
        }
        await _pizzariaContext.SaveChangesAsync();
        return refrigerante;
    }
    public IEnumerable<FotoRefrigerante> ObterFotoRefrigeranteAsync(int refrigeranteId)
    {
        var fotoRefrigerante = (
                            from frefr in _pizzariaContext.FotoRefrigerantes
                            where frefr.RefrigeranteId == refrigeranteId
                            orderby frefr.RefrigeranteId ascending
                            select new FotoRefrigerante
                            (
                                 frefr.FotoRefrigeranteId,
                                 frefr.RefrigeranteId,
                                 frefr.Foto

                            )).ToList();


        return fotoRefrigerante;
    }

    public async Task<FotoRefrigerante> SalvarFotoRefrigerante(FotoRefrigerante fotoRefrigerante)
    {
        _pizzariaContext.Entry(fotoRefrigerante).State = EntityState.Modified;

        _pizzariaContext.FotoRefrigerantes.Add(fotoRefrigerante);
        await _pizzariaContext.SaveChangesAsync();

        return fotoRefrigerante;
    }

    public async Task<FotoRefrigerante> ExcluirFotoRefrigerante(int fotoRefrigeranteId)
    {

        var fotorefrigerante = await _pizzariaContext.FotoRefrigerantes.FindAsync(fotoRefrigeranteId);
        if (fotorefrigerante != null)
        {
            _pizzariaContext.FotoRefrigerantes.Remove(fotorefrigerante);
        }
        await _pizzariaContext.SaveChangesAsync();
        return fotorefrigerante;
    }

}

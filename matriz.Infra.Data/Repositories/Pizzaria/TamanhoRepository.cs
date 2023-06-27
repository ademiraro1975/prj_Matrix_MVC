using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Interfaces;
using matriz.Infra.Data.Context;
using matriz.Core.Domain.Entities.Pizzaria;

namespace matriz.Infra.Data.Repositories;

public class TamanhoRepository : ITamanhoRepository
{
    private readonly PizzariaContext _pizzariaContext;

    public TamanhoRepository(PizzariaContext pizzariaContext)
    {
        _pizzariaContext = pizzariaContext;
    }
    public async Task<IEnumerable<Tamanho>> ObterListaTamanhoAsync()
    {
        var tamanho = (
                            from tam in _pizzariaContext.Tamanhos
                                //where func.Email == email
                            orderby tam.Descricao ascending
                            select new Tamanho
                            (
                                 tam.TamanhoId,
                                 tam.Descricao,
                                 tam.NumPedaco

                            )).ToListAsync();


        return await tamanho;
    }

    public Tamanho ObterTamanhoAsync(int tamanhoId)
    {
        var tamanho = (
                             from tam in _pizzariaContext.Tamanhos
                             where tam.TamanhoId == tamanhoId
                             orderby tam.Descricao ascending
                             select new Tamanho
                             (
                                  tam.TamanhoId,
                                  tam.Descricao,
                                  tam.NumPedaco
                             )).FirstOrDefault();


        return tamanho;
    }

    public async Task<Tamanho> SalvarTamanho(Tamanho tamanho)
    {
        _pizzariaContext.Entry(tamanho).State = EntityState.Modified;

        _pizzariaContext.Tamanhos.Add(tamanho);
        await _pizzariaContext.SaveChangesAsync();

        return tamanho;
    }

    public async Task<Tamanho> AlterarTamanho(Tamanho tamanho)
    {
        _pizzariaContext.Entry(tamanho).State = EntityState.Modified;

        _pizzariaContext.Tamanhos.Update(tamanho);
        await _pizzariaContext.SaveChangesAsync();

        return tamanho;
    }


    public async Task<Tamanho> ExcluirTamanho(int tamanhoId)
    {

        var tamanho = await _pizzariaContext.Tamanhos.FindAsync(tamanhoId);
        if (tamanho != null)
        {
            _pizzariaContext.Tamanhos.Remove(tamanho);
        }
        await _pizzariaContext.SaveChangesAsync();

        return tamanho;
    }
}

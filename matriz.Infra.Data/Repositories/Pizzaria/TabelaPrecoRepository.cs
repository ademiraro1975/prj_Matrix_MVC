using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Interfaces;
using matriz.Infra.Data.Context;
using matriz.Core.Domain.Entities.Pizzaria;

namespace matriz.Infra.Data.Repositories;

public class TabelaPrecoRepository : ITabelaPrecoRepository
{
    private readonly PizzariaContext _pizzariaContext;

    public TabelaPrecoRepository(PizzariaContext pizzariaContext)
    {
        _pizzariaContext = pizzariaContext;
    }
    public async Task<IEnumerable<TabelaPreco>> ObterListaTabelaPrecoAsync()
    {
        var tabelaPreco = (
                            from tpr in _pizzariaContext.TabelaPrecos
                                //where func.Email == email
                            orderby tpr.Preco ascending
                            select new TabelaPreco
                            (
                                 tpr.TabelaPrecoId,
                                 tpr.Preco

                            )).ToListAsync();


        return await tabelaPreco;
    }

    public TabelaPreco ObterTabelaPrecoAsync(int tabelaPrecoId)
    {
        var tabelaPreco = (
                             from tpr in _pizzariaContext.TabelaPrecos
                             where tpr.TabelaPrecoId == tabelaPrecoId
                             orderby tpr.Preco ascending
                             select new TabelaPreco
                            (
                                 tpr.TabelaPrecoId,
                                 tpr.Preco
                             )).FirstOrDefault();


        return tabelaPreco;
    }

    public async Task<TabelaPreco> SalvarTabelaPreco(TabelaPreco tabelaPreco)
    {
        _pizzariaContext.Entry(tabelaPreco).State = EntityState.Modified;

        _pizzariaContext.TabelaPrecos.Add(tabelaPreco);
        await _pizzariaContext.SaveChangesAsync();

        return tabelaPreco;
    }

    public async Task<TabelaPreco> AlterarTabelaPreco(TabelaPreco tabelaPreco)
    {
        _pizzariaContext.Entry(tabelaPreco).State = EntityState.Modified;

        _pizzariaContext.TabelaPrecos.Update(tabelaPreco);
        await _pizzariaContext.SaveChangesAsync();

        return tabelaPreco;
    }


    public async Task<TabelaPreco> ExcluirTabelaPreco(int tabelaPrecoId)
    {

        var tabelaPreco = await _pizzariaContext.TabelaPrecos.FindAsync(tabelaPrecoId);
        if (tabelaPreco != null)
        {
            _pizzariaContext.TabelaPrecos.Remove(tabelaPreco);
        }
        await _pizzariaContext.SaveChangesAsync();

        return tabelaPreco;
    }
}

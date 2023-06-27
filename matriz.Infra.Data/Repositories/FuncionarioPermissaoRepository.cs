using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Interfaces;
using matriz.Infra.Data.Context;

namespace matriz.Infra.Data.Repositories;

public class FuncionarioPermissaoRepository : IFuncionarioPermissaoRepository
{
    private readonly AppDbContext _appDbContext;

    public FuncionarioPermissaoRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<List<FuncionarioPermissao>> ObterFuncionarioPermissaoAsync(string email, string sistema)
    {
        var funcionarioPermissao = from f in _appDbContext.Funcionarios
                                   where f.Email.Equals(email)
                                   select new FuncionarioPermissao(
                                        f.Id,
                                        f.Nome,
                                        f.Email,
                                        f.FotoUrl
                                       );

        return await funcionarioPermissao.ToListAsync();
    }
}

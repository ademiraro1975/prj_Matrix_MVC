using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities;
using matriz.Infra.Data.Context;
using matriz.Core.Domain.Interfaces.PontuacaoProfessor;

namespace matriz.Infra.Data.Repositories.PontuacaoProfessor;

public class FuncionarioPermissaoRepository : IFuncionarioPermissaoRepository
{
    private readonly AppDbContext _appDbContext;

    public FuncionarioPermissaoRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<List<FuncionarioPermissaoConfigurarion>> ObterFuncionarioPermissaoAsync(string email, string sistema)
    {
        var funcionarioPermissao = from f in _appDbContext.Funcionarios
                                   where f.Email.Equals(email)
                                   select new FuncionarioPermissaoConfigurarion(
                                        f.Id,
                                        f.Nome,
                                        f.Email,
                                        f.FotoUrl
                                       );

        return await funcionarioPermissao.ToListAsync();
    }
}

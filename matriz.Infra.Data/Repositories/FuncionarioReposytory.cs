using Microsoft.EntityFrameworkCore;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Interfaces;
using matriz.Infra.Data.Context;

namespace matriz.Infra.Data.Repositories;

public class FuncionarioRepository : IFuncionarioRepository
{
    private readonly AppDbContext _appDbContext;

    public FuncionarioRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Funcionario> ObterFuncionarioPorEmailAsync(string email)
    {
        var funcionario = (
                            from func in _appDbContext.Funcionarios
                               where func.Email == email
                               orderby func.Nome ascending
                               select new Funcionario
                               (
                                    func.Id,
                                    func.Codigo,
                                    func.CPF,
                                    func.Email,
                                    func.FotoUrl,
                                    func.Nome,
                                    func.RG
                               ));


        return await funcionario.FirstOrDefaultAsync();
    }    
}

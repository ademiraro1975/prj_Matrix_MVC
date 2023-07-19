using Microsoft.EntityFrameworkCore;
using matriz.Infra.Data.Context;
using matriz.Core.Domain.Interfaces.PontuacaoProfessor;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Infra.Data.Repositories.PontuacaoProfessor;

public class ProfessorRepository : IProfessorRepository
{
    private readonly AppDbContext _appDbContext;

    public ProfessorRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public Task<Professor> ObterListaProfessorAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Professor> ObterProfessorPorEmailAsync(string email)
    {
        //var professor = 
        //                    from func in _appDbContext.Funcionarios
        //                    where func.Email == email
        //                    orderby func.Nome ascending
        //                    select new Professor
        //                    (
        //                         func.Id,
        //                         func.Codigo,
        //                         func.CPF,
        //                         func.Email,
        //                         func.FotoUrl,
        //                         func.Nome,
        //                         func.RG,
        //                         func.DataNascimento,
        //                         func.NumDependentes
        //                    );


        //return await professor.FirstOrDefaultAsync();

        throw new NotImplementedException();
    }
}

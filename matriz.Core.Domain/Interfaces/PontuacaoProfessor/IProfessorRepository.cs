using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Core.Domain.Interfaces.PontuacaoProfessor;

public interface IProfessorRepository
{
    Task<Professor> ObterProfessorPorEmailAsync(string email);
    Task<Professor> ObterListaProfessorAsync();
}

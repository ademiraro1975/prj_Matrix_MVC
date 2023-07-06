using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Entities.PontuacaoProfessor;

namespace matriz.Core.Domain.Interfaces.PontuacaoProfessor;

public interface IFuncionarioRepository
{
    Task<Funcionario> ObterFuncionarioPorEmailAsync(string email);
}

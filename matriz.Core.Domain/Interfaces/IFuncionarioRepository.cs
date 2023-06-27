using matriz.Core.Domain.Entities;

namespace matriz.Core.Domain.Interfaces;

public interface IFuncionarioRepository
{ 
    Task<Funcionario> ObterFuncionarioPorEmailAsync(string email);
}

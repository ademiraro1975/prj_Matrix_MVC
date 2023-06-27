using matriz.Core.Domain.Entities;

namespace matriz.Core.Domain.Interfaces;

public interface IFuncionarioPermissaoRepository
{
    Task<List<FuncionarioPermissao>> ObterFuncionarioPermissaoAsync(string email, string sistema);
}

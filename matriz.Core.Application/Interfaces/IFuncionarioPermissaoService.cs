using matriz.Core.Application.DTOs;

namespace matriz.Core.Application.Interfaces;

public interface IFuncionarioPermissaoService
{
    Task<List<FuncionarioPermissaoDTO>> ObterFuncionarioPermissaoAsync(string email, string sistema);
}

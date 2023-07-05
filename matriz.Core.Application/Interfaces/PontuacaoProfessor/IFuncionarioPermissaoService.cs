using matriz.Core.Application.DTOs.PontuacaoProfessor;

namespace matriz.Core.Application.Interfaces.PontuacaoProfessor;

public interface IFuncionarioPermissaoService
{
    Task<List<FuncionarioPermissaoDTO>> ObterFuncionarioPermissaoAsync(string email, string sistema);
}

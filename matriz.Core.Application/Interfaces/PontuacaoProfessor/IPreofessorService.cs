using matriz.Core.Domain.Entities.PontuacaoProfessor;


namespace matriz.Core.Application.Interfaces.PontuacaoProfessor
{
    public interface IProfessorService
    {
        Task<ProfessorDTO> ObterProfessorPorEmailAsync(string email);

        Task<ProfessorDTO> ObterListaProfessorAsync();
    }
}

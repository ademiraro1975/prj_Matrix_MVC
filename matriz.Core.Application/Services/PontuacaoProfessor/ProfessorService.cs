using AutoMapper;
using matriz.Core.Application.DTOs.PontuacaoProfessor;
using matriz.Core.Application.Interfaces.PontuacaoProfessor;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Entities.PontuacaoProfessor;
using matriz.Core.Domain.Interfaces.PontuacaoProfessor;

namespace matriz.Core.Application.Services.PontuacaoProfessor
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository _professorRepository;
        private readonly IMapper _mapper;

        public ProfessorService(IProfessorRepository professorRepository, IMapper mapper)
        {
            _professorRepository = professorRepository;
            _mapper = mapper;
        }

        public async Task<ProfessorDTO> ObterListaProfessorAsync()
        {
            var professor = await _professorRepository.ObterListaProfessorAsync();
            return _mapper.Map<ProfessorDTO>(professor);
        }

        public Task<ProfessorDTO> ObterProfessorPorEmailAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}
using AutoMapper;
using matriz.Core.Application.DTOs.PontuacaoProfessor;
using matriz.Core.Application.Interfaces.PontuacaoProfessor;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Interfaces.PontuacaoProfessor;

namespace matriz.Core.Application.Services.PontuacaoProfessor
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly IMapper _mapper;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository, IMapper mapper)
        {
            _funcionarioRepository = funcionarioRepository;
            _mapper = mapper;
        }

        public async Task<FuncionarioDTO> ObterFuncionarioPorEmailAsync(string email)
        {
            var funcionario = await _funcionarioRepository.ObterFuncionarioPorEmailAsync(email);
            return _mapper.Map<FuncionarioDTO>(funcionario);
        }

    }
}
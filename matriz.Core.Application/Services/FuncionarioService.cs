using AutoMapper;
using matriz.Core.Application.DTOs;
using matriz.Core.Application.Interfaces;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Interfaces;

namespace matriz.Core.Application.Services
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
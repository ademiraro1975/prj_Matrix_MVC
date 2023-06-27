using AutoMapper;
using matriz.Core.Application.DTOs;
using matriz.Core.Application.Interfaces;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Interfaces;

namespace matriz.Core.Application.Services
{
    public class FuncionarioPermissaoService : IFuncionarioPermissaoService
    {
        private readonly IFuncionarioPermissaoRepository _funcionarioPermissaoRepository;
        private readonly IMapper _mapper;

        public FuncionarioPermissaoService(IFuncionarioPermissaoRepository funcionarioPermissaoRepository, IMapper mapper)
        {
            _funcionarioPermissaoRepository = funcionarioPermissaoRepository;
            _mapper = mapper;
        }

        public async Task<List<FuncionarioPermissaoDTO>> ObterFuncionarioPermissaoAsync(string email, string sistema)
        {
            var funcionarioPermissao = await _funcionarioPermissaoRepository.ObterFuncionarioPermissaoAsync(email, sistema);
            return _mapper.Map<List<FuncionarioPermissaoDTO>>(funcionarioPermissao);
        }
    }
}
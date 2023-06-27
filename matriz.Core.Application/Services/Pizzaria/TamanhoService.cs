using AutoMapper;
using matriz.Core.Application.DTOs.Pizzaria;
using matriz.Core.Application.Interfaces;
using matriz.Core.Domain.Entities.Pizzaria;
using matriz.Core.Domain.Interfaces;

namespace matriz.Core.Application.Services
{
    public class TamanhoService : ITamanhoService
    {
        private readonly ITamanhoRepository _tamanhoRepository;
        private readonly IMapper _mapper;

        public TamanhoService(ITamanhoRepository tamanhoRepository, IMapper mapper)
        {
            _tamanhoRepository = tamanhoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TamanhoDTO>> ObterListaTamanhoAsync()
        {
            var tamanho = await _tamanhoRepository.ObterListaTamanhoAsync();
            return _mapper.Map<IEnumerable<TamanhoDTO>>(tamanho);
        }

        public async Task<TamanhoDTO> SalvarTamanho(Tamanho tamanho)
        {
            var tamanhoSalvar = await _tamanhoRepository.SalvarTamanho(tamanho);
            return _mapper.Map<TamanhoDTO>(tamanhoSalvar);

        }
        public async Task<TamanhoDTO> AlterarTamanho(Tamanho tamanho)
        {
            var tamanhoSalvar = await _tamanhoRepository.AlterarTamanho(tamanho);
            return _mapper.Map<TamanhoDTO>(tamanhoSalvar);

        }
        public async Task<TamanhoDTO> ExcluirTamanho(int tamanhoId)
        {
            var tamanhoExcluir = await _tamanhoRepository.ExcluirTamanho(tamanhoId);
            return _mapper.Map<TamanhoDTO>(tamanhoExcluir);

        }

        public TamanhoDTO ObterTamanhoAsync(int tamanhoId)
        {
            var tamanho = _tamanhoRepository.ObterTamanhoAsync(tamanhoId);
            return _mapper.Map<TamanhoDTO>(tamanho);
        }
    }
}
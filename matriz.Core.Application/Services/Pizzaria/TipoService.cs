using AutoMapper;
using matriz.Core.Application.DTOs.Pizzaria;
using matriz.Core.Application.Interfaces;
using matriz.Core.Domain.Entities.Pizzaria;
using matriz.Core.Domain.Interfaces;

namespace matriz.Core.Application.Services
{
    public class TipoService : ITipoService
    {
        private readonly ITipoRepository _tipoRepository;
        private readonly IMapper _mapper;

        public TipoService(ITipoRepository tipoRepository, IMapper mapper)
        {
            _tipoRepository = tipoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TipoDTO>> ObterListaTipoAsync()
        {
            var tipo = await _tipoRepository.ObterListaTipoAsync();
            return _mapper.Map<IEnumerable<TipoDTO>>(tipo);
        }

        public async Task<TipoDTO> SalvarTipo(Tipo tipo)
        {
            var tipoSalvar = await _tipoRepository.SalvarTipo(tipo);
            return _mapper.Map<TipoDTO>(tipoSalvar);

        }
        public async Task<TipoDTO> AlterarTipo(Tipo tipo)
        {
            var tipoSalvar = await _tipoRepository.AlterarTipo(tipo);
            return _mapper.Map<TipoDTO>(tipoSalvar);

        }
        public async Task<TipoDTO> ExcluirTipo(int tipoId)
        {
            var tipoExcluir = await _tipoRepository.ExcluirTipo(tipoId);
            return _mapper.Map<TipoDTO>(tipoExcluir);

        }

        public TipoDTO ObterTipoAsync(int tipoId)
        {
            var tipo = _tipoRepository.ObterTipoAsync(tipoId);
            return _mapper.Map<TipoDTO>(tipo);
        }
    }
}
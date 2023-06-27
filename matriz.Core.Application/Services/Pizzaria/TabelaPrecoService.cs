using AutoMapper;
using matriz.Core.Application.DTOs.Pizzaria;
using matriz.Core.Application.Interfaces;
using matriz.Core.Domain.Entities.Pizzaria;
using matriz.Core.Domain.Interfaces;

namespace matriz.Core.Application.Services
{
    public class TabelaPrecoService : ITabelaPrecoService
    {
        private readonly ITabelaPrecoRepository _tabelaPrecoRepository;
        private readonly IMapper _mapper;

        public TabelaPrecoService(ITabelaPrecoRepository tabelaPrecoRepository, IMapper mapper)
        {
            _tabelaPrecoRepository = tabelaPrecoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TabelaPrecoDTO>> ObterListaTabelaPrecoAsync()
        {
            var ingrediente = await _tabelaPrecoRepository.ObterListaTabelaPrecoAsync();
            return _mapper.Map<IEnumerable<TabelaPrecoDTO>>(ingrediente);
        }

        public async Task<TabelaPrecoDTO> SalvarTabelaPreco(TabelaPreco tabelaPreco)
        {
            var tabelaPrecoSalvar = await _tabelaPrecoRepository.SalvarTabelaPreco(tabelaPreco);
            return _mapper.Map<TabelaPrecoDTO>(tabelaPrecoSalvar);

        }

        public async Task<TabelaPrecoDTO> AlterarTabelaPreco(TabelaPreco tabelaPreco)
        {
            var tabelaPrecoSalvar = await _tabelaPrecoRepository.AlterarTabelaPreco(tabelaPreco);
            return _mapper.Map<TabelaPrecoDTO>(tabelaPrecoSalvar);

        }

        public async Task<TabelaPrecoDTO> ExcluirTabelaPreco(int tabelaPrecoId)
        {
            var tabelaPrecoExcluir = await _tabelaPrecoRepository.ExcluirTabelaPreco(tabelaPrecoId);
            return _mapper.Map<TabelaPrecoDTO>(tabelaPrecoExcluir);

        }

        public TabelaPrecoDTO ObterTabelaPrecoAsync(int tabelaPrecoId)
        {
            var tabelaPreco = _tabelaPrecoRepository.ObterTabelaPrecoAsync(tabelaPrecoId);
            return _mapper.Map<TabelaPrecoDTO>(tabelaPreco);
        }

    }
}
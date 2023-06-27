using AutoMapper;
using matriz.Core.Application.DTOs.Pizzaria;
using matriz.Core.Application.Interfaces;
using matriz.Core.Domain.Entities.Pizzaria;
using matriz.Core.Domain.Interfaces;

namespace matriz.Core.Application.Services
{
    public class RefrigeranteService : IRefrigeranteService
    {
        private readonly IRefrigeranteRepository _refrigeranteRepository;
        private readonly IMapper _mapper;

        public RefrigeranteService(IRefrigeranteRepository refrigeranteRepository, IMapper mapper)
        {
            _refrigeranteRepository = refrigeranteRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RefrigeranteDTO>> ObterListaRefrigeranteAsync()
        {
            var refrigerante = await _refrigeranteRepository.ObterListaRefrigeranteAsync();
            return _mapper.Map<IEnumerable<RefrigeranteDTO>>(refrigerante);
        }
        public RefrigeranteDTO ObterRefrigeranteAsync(int refrigeranteId)
        {
            var refrigerante = _refrigeranteRepository.ObterRefrigeranteAsync(refrigeranteId);
            return _mapper.Map<RefrigeranteDTO>(refrigerante);
        }

        public async Task<RefrigeranteDTO> SalvarRefrigerante(Refrigerante refrigerante)
        {
            var refrigeranteSalvo = await _refrigeranteRepository.SalvarRefrigerante(refrigerante);
            return _mapper.Map<RefrigeranteDTO>(refrigeranteSalvo);

        }
        public async Task<RefrigeranteDTO> AlterarRefrigerante(Refrigerante refrigerante)
        {
            var refrigeranteSalvo = await _refrigeranteRepository.AlterarRefrigerante(refrigerante);
            return _mapper.Map<RefrigeranteDTO>(refrigeranteSalvo);

        }
        public async Task<RefrigeranteDTO> ExcluirRefrigerante(int refrigeranteId)
        {
            var refrigeranteExcluir = await _refrigeranteRepository.ExcluirRefrigerante(refrigeranteId);
            return _mapper.Map<RefrigeranteDTO>(refrigeranteExcluir);

        }
        public IEnumerable<FotoRefrigeranteDTO> ObterFotoRefrigeranteAsync(int refrigeranteId)
        {
            var refrigerante = _refrigeranteRepository.ObterFotoRefrigeranteAsync(refrigeranteId);
            return _mapper.Map<IEnumerable<FotoRefrigeranteDTO>>(refrigerante);
        }
        public async Task<FotoRefrigeranteDTO> ExcluirFotoRefrigerante(int fotoRefrigeranteId)
        {
            var refrigeranteExcluir = await _refrigeranteRepository.ExcluirFotoRefrigerante(fotoRefrigeranteId);
            return _mapper.Map<FotoRefrigeranteDTO>(refrigeranteExcluir);

        }
        public async Task<FotoRefrigeranteDTO> SalvarFotoRefrigerante(FotoRefrigerante fotoRefrigerante)
        {
            var refrigeranteFotoSalvar = await _refrigeranteRepository.SalvarFotoRefrigerante(fotoRefrigerante);
            return _mapper.Map<FotoRefrigeranteDTO>(refrigeranteFotoSalvar);

        }
    }
}
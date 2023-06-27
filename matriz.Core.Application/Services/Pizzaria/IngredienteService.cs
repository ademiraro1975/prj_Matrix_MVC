using AutoMapper;
using matriz.Core.Application.DTOs.Pizzaria;
using matriz.Core.Application.Interfaces;
using matriz.Core.Domain.Entities.Pizzaria;
using matriz.Core.Domain.Interfaces;

namespace matriz.Core.Application.Services
{
    public class IngredienteService : IIngredienteService
    {
        private readonly IIngredienteRepository _ingredienteRepository;
        private readonly IMapper _mapper;

        public IngredienteService(IIngredienteRepository ingredienteRepository, IMapper mapper)
        {
            _ingredienteRepository = ingredienteRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<IngredienteDTO>> ObterListaIngredienteAsync()
        {
            var ingrediente = await _ingredienteRepository.ObterListaIngredienteAsync();
            return _mapper.Map<IEnumerable<IngredienteDTO>>(ingrediente);
        }



        public async Task<IngredienteDTO> SalvarIngrediente(Ingrediente ingrediente)
        {
            var ingredienteSalvar = await _ingredienteRepository.SalvarIngrediente(ingrediente);
            return _mapper.Map<IngredienteDTO>(ingredienteSalvar);

        }        
        public async Task<IngredienteDTO> AlterarIngrediente(Ingrediente ingrediente)
        {
            var ingredienteSalvar = await _ingredienteRepository.AlterarIngrediente(ingrediente);
            return _mapper.Map<IngredienteDTO>(ingredienteSalvar);

        }
        public async Task<IngredienteDTO> ExcluirIngrediente(int ingredienteId)
        {
            var ingredienteExcluir = await _ingredienteRepository.ExcluirIngrediente(ingredienteId);
            return _mapper.Map<IngredienteDTO>(ingredienteExcluir);

        }

        public IngredienteDTO ObterIngredienteAsync(int ingredienteId)
        {
            var ingrediente = _ingredienteRepository.ObterIngredienteAsync(ingredienteId);
            return _mapper.Map<IngredienteDTO>(ingrediente);
        }
    }
}
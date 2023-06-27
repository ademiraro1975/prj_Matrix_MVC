using AutoMapper;
using matriz.Core.Application.DTOs.Pizzaria;
using matriz.Core.Application.Interfaces;
using matriz.Core.Domain.Entities.Pizzaria;
using matriz.Core.Domain.Interfaces;

namespace matriz.Core.Application.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _pizzaRepository;
        private readonly IMapper _mapper;

        public PizzaService(IPizzaRepository pizzaRepository, IMapper mapper)
        {
            _pizzaRepository = pizzaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PizzaDTO>> ObterListaPizzaAsync()
        {
            var pizza = await _pizzaRepository.ObterListaPizzaAsync();
            return _mapper.Map<IEnumerable<PizzaDTO>>(pizza);
        }

        

        public async Task<PizzaDTO> SalvarPizza(Pizza pizza)
        {
            var pizzaSalva = await _pizzaRepository.SalvarPizza(pizza);
           return _mapper.Map<PizzaDTO>(pizzaSalva);
            
        }
        public IEnumerable<FotoPizzaDTO> ObterFotoPizzaAsync(int pizzaId)
        {
            var pizza =  _pizzaRepository.ObterFotoPizzaAsync(pizzaId);
            return _mapper.Map<IEnumerable<FotoPizzaDTO>>(pizza);
        }

        public IEnumerable<IngredienteDTO> ObterIngredientePizzaAsync(int pizzaId)
        {
            var pizza = _pizzaRepository.ObterIngredientePizzaAsync(pizzaId);
            return _mapper.Map<IEnumerable<IngredienteDTO>>(pizza);
        }
        public IEnumerable<PizzaDetalheDTO> ObterPizzaDetalheAsync(int pizzaId)
        {
            var pizzaDetalhe = _pizzaRepository.ObterPizzaDetalheAsync(pizzaId);
            return _mapper.Map<IEnumerable<PizzaDetalheDTO>>(pizzaDetalhe);
        }

        public async Task<FotoPizzaDTO> ExcluirFotoPizza(int fotoPizzaId)
        {
            var pizzaExcluir = await _pizzaRepository.ExcluirFotoPizza(fotoPizzaId);
            return _mapper.Map<FotoPizzaDTO>(pizzaExcluir);

        }

        public async Task<PizzaIngredienteDTO> ExcluirPizzaIngrediente(int pizzaId, int ingredienteId)
        {
            var pizzaIngredienteExcluir = await _pizzaRepository.ExcluirPizzaIngrediente(pizzaId, ingredienteId);
            return _mapper.Map<PizzaIngredienteDTO>(pizzaIngredienteExcluir);

        }
        public async Task<PizzaDetalheDTO> ExcluirPizzaDetalhe(int pizzaDetalheId)
        {
            var pizzaDetalheExcluir = await _pizzaRepository.ExcluirPizzaDetalhe(pizzaDetalheId);
            return _mapper.Map<PizzaDetalheDTO>(pizzaDetalheExcluir);

        }
        public async Task<FotoPizzaDTO> SalvarFotoPizza(FotoPizza fotoPizza)
        {
            var pizzaFotoSalvar = await _pizzaRepository.SalvarFotoPizza(fotoPizza);
            return _mapper.Map<FotoPizzaDTO>(pizzaFotoSalvar);

        }
        public async Task<PizzaIngredienteDTO> SalvarPizzaIngrediente(PizzaIngrediente pizzaIngrediente)
        {
            var pizzaIngredienteSalvar = await _pizzaRepository.SalvarPizzaIngrediente(pizzaIngrediente);
            return _mapper.Map<PizzaIngredienteDTO>(pizzaIngredienteSalvar);

        }

        public async Task<PizzaDTO> AlterarPizza(Pizza pizza)
        {
            var pizzaSalva = await _pizzaRepository.AlterarPizza(pizza);
            return _mapper.Map<PizzaDTO>(pizzaSalva);

        }

        public async Task<PizzaDetalheDTO> AdicionarPizzaDetalhe(PizzaDetalhe pizzaDetalhe)
        {
            var pizzaDetalheSalva = await _pizzaRepository.AdicionarPizzaDetalhe(pizzaDetalhe);
            return _mapper.Map<PizzaDetalheDTO>(pizzaDetalheSalva);

        }
        public async Task<PizzaDTO> ExcluirPizza(int pizzaId)
        {
            var pizzaExcluir = await _pizzaRepository.ExcluirPizza(pizzaId);
            return _mapper.Map<PizzaDTO>(pizzaExcluir);

        }

        public PizzaDTO ObterPizzaAsync(int pizzaId)
        {
            var pizza = _pizzaRepository.ObterPizzaAsync(pizzaId);
            return _mapper.Map<PizzaDTO>(pizza);
        }
    }
}
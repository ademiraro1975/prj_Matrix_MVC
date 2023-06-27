using AutoMapper;
using matriz.Core.Application.DTOs;
using matriz.Core.Application.DTOs.Pizzaria;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Entities.Pizzaria;
using System.Collections.Generic;

namespace matriz.Core.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile() 
        { 
            CreateMap<Estado, EstadoDTO>().ReverseMap();
            CreateMap<Funcionario, FuncionarioDTO>().ReverseMap();
            CreateMap<FuncionarioPermissao, FuncionarioPermissaoDTO>().ReverseMap();
            CreateMap<FotoPizza, FotoPizzaDTO>().ReverseMap();
            CreateMap<FotoRefrigerante, FotoRefrigeranteDTO>().ReverseMap();
            CreateMap<Ingrediente, IngredienteDTO>().ReverseMap();
            CreateMap<Pizza, PizzaDTO>().ReverseMap();
            CreateMap<PizzaDetalhe, PizzaDetalheDTO>().ReverseMap();
            CreateMap<PizzaIngrediente, PizzaIngredienteDTO>().ReverseMap();
            CreateMap<Refrigerante, RefrigeranteDTO>().ReverseMap();
            CreateMap<RefrigeranteDetalhe, RefrigeranteDetalheDTO>().ReverseMap();
            CreateMap<TabelaPreco, TabelaPrecoDTO>().ReverseMap();
            CreateMap<Tamanho, TamanhoDTO>().ReverseMap();
            CreateMap<Tipo, TipoDTO>().ReverseMap();
    }
    }
}

using AutoMapper;
using matriz.Core.Application.DTOs;
using matriz.Core.Domain.Entities;
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

    }
    }
}

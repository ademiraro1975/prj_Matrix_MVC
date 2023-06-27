using AutoMapper;
using matriz.Core.Application.DTOs;
using matriz.Core.Application.Interfaces;
using matriz.Core.Domain.Interfaces;

namespace matriz.Core.Application.Services
{
    public class EstadoService : IEstadoService
    {
        private readonly IEstadoRepository _estadoRepository;
        private readonly IMapper _mapper;

        public EstadoService(IEstadoRepository estadoRepository, IMapper mapper)
        {
            _estadoRepository = estadoRepository;
            _mapper = mapper;
        }

        public string ObterSiglaEstadoPorId(int estadoId)
        {
            var estado = _estadoRepository.ObterSiglaEstadoPorId(estadoId);

            return estado;
        }
        public string ObterSiglaEstadoPorCidadeId(int cidadeId)
        {
            var estado = _estadoRepository.ObterSiglaEstadoPorCidadeId(cidadeId);

            return estado;
        }
    }
}

using matriz.Core.Application.DTOs;
using matriz.Core.Application.DTOs.Pizzaria;
using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Entities.Pizzaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.Core.Application.Interfaces
{
    public interface IRefrigeranteService
    {
        Task<IEnumerable<RefrigeranteDTO>> ObterListaRefrigeranteAsync();
        RefrigeranteDTO ObterRefrigeranteAsync(int refrigeranteId);
        Task<RefrigeranteDTO> SalvarRefrigerante(Refrigerante pizza);
        Task<RefrigeranteDTO> AlterarRefrigerante(Refrigerante pizza);
        Task<RefrigeranteDTO> ExcluirRefrigerante(int refrigeranteId);
        Task<FotoRefrigeranteDTO> ExcluirFotoRefrigerante(int fotoRegrigeranteId);
        
        IEnumerable<FotoRefrigeranteDTO> ObterFotoRefrigeranteAsync(int refrigeranteId);
        Task<FotoRefrigeranteDTO> SalvarFotoRefrigerante(FotoRefrigerante fotoRefrigerante);

    }
}

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
    public interface IIngredienteService
    {
        Task<IEnumerable<IngredienteDTO>> ObterListaIngredienteAsync();

        IngredienteDTO ObterIngredienteAsync(int ingredienteId);
        Task<IngredienteDTO> SalvarIngrediente(Ingrediente ingrediente);
        Task<IngredienteDTO> AlterarIngrediente(Ingrediente ingrediente);
        Task<IngredienteDTO> ExcluirIngrediente(int ingredienteId);

    }
}

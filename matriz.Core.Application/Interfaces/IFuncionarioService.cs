using matriz.Core.Application.DTOs;
using matriz.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.Core.Application.Interfaces
{
    public interface IFuncionarioService
    { 
        Task<FuncionarioDTO> ObterFuncionarioPorEmailAsync(string email);
        /*string ObterNacionalidadePorId(int naturalidadeId)*/
    }
}

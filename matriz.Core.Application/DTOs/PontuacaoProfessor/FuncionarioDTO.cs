using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.Core.Application.DTOs.PontuacaoProfessor
{
    public class FuncionarioDTO
    {
        public FuncionarioDTO(string codigo, string cPF, string email, string fotoUrl, string nome, string rG, DateTime dataNascimento, int numDependentes)
        {
            Codigo = codigo;
            CPF = cPF;
            Email = email;
            FotoUrl = fotoUrl;
            Nome = nome;
            RG = rG;
            DataNascimento = dataNascimento;
            NumDependentes = numDependentes;
        }

        public FuncionarioDTO(int id, string codigo, string cPF, string email, string fotoUrl, string nome, string rG, DateTime dataNascimento, int numDependentes)
        {
            Id = id;
            Codigo = codigo;
            CPF = cPF;
            Email = email;
            FotoUrl = fotoUrl;
            Nome = nome;
            RG = rG;
            DataNascimento = dataNascimento;
            NumDependentes = numDependentes;
        }

        public int Id { get; private set; }
        public string Codigo { get; private set; } = string.Empty;
        public string CPF { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string FotoUrl { get; private set; } = string.Empty;
        public string Nome { get; private set; } = string.Empty;
        public string RG { get; private set; } = string.Empty;
        public DateTime DataNascimento { get; private set; }
        public int NumDependentes { get; private set; }
    }
}

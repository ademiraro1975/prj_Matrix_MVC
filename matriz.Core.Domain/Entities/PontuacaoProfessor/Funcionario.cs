using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Funcionario
    {
        public int Id { get; private set; }
        public string Codigo { get; private set; } = string.Empty;
        public string CPF { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string FotoUrl { get; private set; } = string.Empty;
        public string Nome { get; private set; } = string.Empty;
        public string RG { get; private set; } = string.Empty;
        public DateTime DataNascimento { get; private set; }
        public int NumDependentes { get; private set; }

        public ICollection<FuncionarioCargoDepartamentoUnidade> FuncionarioCargoDepartamentos { get; } = new List<FuncionarioCargoDepartamentoUnidade>();

        public Funcionario()
        {
            FuncionarioCargoDepartamentos = new HashSet<FuncionarioCargoDepartamentoUnidade>();
        }

    }
}
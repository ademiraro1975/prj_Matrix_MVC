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

        public ICollection<FuncionarioCargoDepartamentoUnidade> FuncionarioCargoDepartamentoUnidades { get; } = new List<FuncionarioCargoDepartamentoUnidade>();
        public ICollection<Usuario> Usuarios { get; } = new List<Usuario>();

        public Funcionario()
        {
            Usuarios = new HashSet<Usuario>();
            FuncionarioCargoDepartamentoUnidades = new HashSet<FuncionarioCargoDepartamentoUnidade>();
        }

        public Funcionario(int id, string codigo, string cPF, string email, string fotoUrl, string nome, string rG, DateTime dataNascimento, int numDependentes)
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
    }
}
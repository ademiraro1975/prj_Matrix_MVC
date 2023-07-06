using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class UnidadeDTO
    {
        public UnidadeDTO(int id, int cEPId, string cNPJ, int codigo, string decreto, string email, string emailSecretariaUnidadeEscolar, string nome, string nomeAbreviado, string nomeCompleto, string enderecoNumero, string telefone, int entidadeId, int idEndereco)
        {
            Id = id;
            CEPId = cEPId;
            CNPJ = cNPJ;
            Codigo = codigo;
            Decreto = decreto;
            Email = email;
            EmailSecretariaUnidadeEscolar = emailSecretariaUnidadeEscolar;
            Nome = nome;
            NomeAbreviado = nomeAbreviado;
            NomeCompleto = nomeCompleto;
            EnderecoNumero = enderecoNumero;
            Telefone = telefone;
            EntidadeId = entidadeId;
            IdEndereco = idEndereco;
        }

        public int Id { get; private set; }
        public int CEPId { get; private set; }
        public string CNPJ { get; private set; } = string.Empty;
        public int Codigo { get; private set; }
        public string Decreto { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string EmailSecretariaUnidadeEscolar { get; set; } = string.Empty;
        public string Nome { get; private set; } = string.Empty;
        public string NomeAbreviado { get; private set; } = string.Empty;
        public string NomeCompleto { get; private set; } = string.Empty;
        public string EnderecoNumero { get; private set; } = string.Empty;
        public string Telefone { get; private set; } = string.Empty;

        public int EntidadeId { get; private set; }
        public int IdEndereco { get; private set; }

    }
}
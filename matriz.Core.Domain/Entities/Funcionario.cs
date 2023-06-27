using System;
using System.Collections.Generic;

namespace matriz.Core.Domain.Entities;

public sealed class Funcionario
{    
    public int Id { get; private set; }
    public string Codigo { get; private set; } = string.Empty;
    public string CPF { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string FotoUrl { get; private set; } = string.Empty;
    public string Nome { get; private set; } = string.Empty;
    public string RG { get; private set; } = string.Empty;

    public Funcionario(int id, string codigo, string cpf, string email, string fotoUrl, string nome, string rg)
    {
        Id = id;
        Codigo = codigo;
        CPF = cpf;
        Email = email;
        FotoUrl = fotoUrl;
        Nome = nome;
        RG = rg;
    }

    public Funcionario(int id, string nome, string email, string fotoUrl)
    {
        Id = id;
        Nome = nome;
        Email = email;
        FotoUrl = fotoUrl;
    }

}

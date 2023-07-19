namespace matriz.Core.Domain.Entities;

public class FuncionarioPermissaoConfigurarion
{

    public int FuncionarioId { get; private set; }
    public int UnidadeId { get; private set; }
    public string Nome { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string FotoUrl { get; private set; } = string.Empty;
    public string Sistema { get; private set; } = string.Empty;
    public string Rotina { get; private set; } = string.Empty;
    public string Operacao { get; private set; } = string.Empty;


    public FuncionarioPermissaoConfigurarion(int funcionarioId, string nome, string email, string fotoUrl)
    {
        FuncionarioId = funcionarioId;
        Nome = nome;
        Email = email;
        FotoUrl = fotoUrl;
    }

    public FuncionarioPermissaoConfigurarion(int funcionarioId, int unidadeId, string nome, string email, string fotoUrl, string sistema, string rotina, string operacao)
    {
        FuncionarioId = funcionarioId;
        UnidadeId = unidadeId;
        Nome = nome;
        Email = email;
        FotoUrl = fotoUrl;
        Sistema = sistema;
        Rotina = rotina;
        Operacao = operacao;
    }
}

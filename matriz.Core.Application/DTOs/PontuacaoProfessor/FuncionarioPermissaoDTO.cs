namespace matriz.Core.Application.DTOs.PontuacaoProfessor;

public class FuncionarioPermissaoDTO
{
    public FuncionarioPermissaoDTO(int funcionarioId, int unidadeId, string nome, string email, string fotoUrl, string sistema, string rotina, string operacao)
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

    public int FuncionarioId { get; set; }
    public int UnidadeId { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string FotoUrl { get; set; } = string.Empty;
    public string Sistema { get; set; } = string.Empty;
    public string Rotina { get; set; } = string.Empty;
    public string Operacao { get; set; } = string.Empty;
}

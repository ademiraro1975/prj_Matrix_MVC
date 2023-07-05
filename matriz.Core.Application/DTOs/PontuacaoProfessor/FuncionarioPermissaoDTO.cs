namespace matriz.Core.Application.DTOs.PontuacaoProfessor;

public class FuncionarioPermissaoDTO
{
    public int FuncionarioId { get; set; }
    public int UnidadeId { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string FotoUrl { get; set; } = string.Empty;
    public string Sistema { get; set; } = string.Empty;
    public string Rotina { get; set; } = string.Empty;
    public string Operacao { get; set; } = string.Empty;
}

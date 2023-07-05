namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class UsuarioDTO
    {

        public int Id { get; private set; }

        public int FuncionarioId { get; private set; }
        public int TipoUsuarioId { get; private set; }

        public Funcionario Funcionario { get; } = new Funcionario();
        public TipoUsuarioDTO TipoUsuario { get; } = new TipoUsuarioDTO();

        public ICollection<UsuarioPermissaoDTO> UsuarioPermissaos { get; } = new List<UsuarioPermissaoDTO>();
        public UsuarioDTO()
        {
            UsuarioPermissaos = new HashSet<UsuarioPermissaoDTO>();
        }

        public UsuarioDTO(int id, int funcionarioId, int tipoUsuarioId)
        {
            Id = id;
            FuncionarioId = funcionarioId;
            TipoUsuarioId = tipoUsuarioId;
        }
    }
}
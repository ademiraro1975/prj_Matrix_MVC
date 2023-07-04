namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class Usuario
    {

        public int Id { get; private set; }

        public int FuncionarioId { get; private set; }
        public int TipoUsuarioId { get; private set; }

        public Funcionario Funcionario { get; } = new Funcionario();
        public TipoUsuario TipoUsuario { get; } = new TipoUsuario();

        public ICollection<UsuarioPermissao> UsuarioPermissaos { get; } = new List<UsuarioPermissao>();
        public Usuario()
        {
            UsuarioPermissaos = new HashSet<UsuarioPermissao>();
        }

        public Usuario(int id, int funcionarioId, int tipoUsuarioId)
        {
            Id = id;
            FuncionarioId = funcionarioId;
            TipoUsuarioId = tipoUsuarioId;
        }
    }
}
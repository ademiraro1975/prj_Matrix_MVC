namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class UsuarioConfigurarion
    {

        public int Id { get; private set; }

        public int FuncionarioId { get; private set; }
        public int TipoUsuarioId { get; private set; }

        public Funcionario Funcionario { get; } = new Funcionario();
        public TipoUsuarioConfigurarion TipoUsuario { get; } = new TipoUsuarioConfigurarion();

        public ICollection<UsuarioPermissaoConfigurarion> UsuarioPermissaos { get; } = new List<UsuarioPermissaoConfigurarion>();
        public UsuarioConfigurarion()
        {
            UsuarioPermissaos = new HashSet<UsuarioPermissaoConfigurarion>();
        }

        public UsuarioConfigurarion(int id, int funcionarioId, int tipoUsuarioId)
        {
            Id = id;
            FuncionarioId = funcionarioId;
            TipoUsuarioId = tipoUsuarioId;
        }
    }
}
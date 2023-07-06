namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class UsuarioDTO
    {
        public UsuarioDTO(int id, int funcionarioId, int tipoUsuarioId)
        {
            Id = id;
            FuncionarioId = funcionarioId;
            TipoUsuarioId = tipoUsuarioId;
        }

        public int Id { get; private set; }

        public int FuncionarioId { get; private set; }
        public int TipoUsuarioId { get; private set; }

    }
}
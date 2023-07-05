namespace matriz.Core.Domain.Entities.PontuacaoProfessor
{
    public sealed class CursoDisciplinaDTO
    {
        public CursoDisciplinaDTO(int id, int cursoId, int disciplinaId)
        {
            Id = id;
            CursoId = cursoId;
            DisciplinaId = disciplinaId;
        }

        public int Id { get; set; }
        public int CursoId { get; set; }
        public int DisciplinaId { get; set; }

    }
}
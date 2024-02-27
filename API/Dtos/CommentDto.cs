using Dominio.Entities;

namespace API.Dtos;

public class CommentDto : BaseEntity
{
    public int IdPost { get; set; }
    public PostDto Post { get; set; }
    public int IdUser { get; set; }
    public UsuarioDto Usuario { get; set; }
    public string CommentText { get; set; }
    public DateOnly CreatedAt { get; set; }
}
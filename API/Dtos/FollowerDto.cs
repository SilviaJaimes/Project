using Dominio.Entities;

namespace API.Dtos;

public class FollowerDto : BaseEntity
{
    public int IdUser { get; set; }
    public UsuarioDto Usuario { get; set; }
    public DateOnly CreatedAt { get; set; }
}
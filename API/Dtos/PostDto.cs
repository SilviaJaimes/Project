using Dominio.Entities;

namespace API.Dtos;

public class PostDto : BaseEntity
{
    public int IdUser { get; set; }
    public UsuarioDto Usuario { get; set; }
    public string UrlImage { get; set; }
    public string Caption { get; set; }
    public DateOnly CreatedAt { get; set; }
}
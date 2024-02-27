namespace Dominio.Entities;

public class Post : BaseEntity
{
    public int IdUser { get; set; }
    public Usuario Usuario { get; set; }
    public string UrlImage { get; set; }
    public string Caption { get; set; }
    public DateOnly CreatedAt { get; set; }

    public ICollection<Comment> Comments { get; set; }
    public ICollection<Like> Likes { get; set; }
}
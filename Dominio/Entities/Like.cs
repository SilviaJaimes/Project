namespace Dominio.Entities;

public class Like : BaseEntity
{
    public int IdPost { get; set; }
    public Post Post { get; set; }
    public int IdUser { get; set; }
    public Usuario Usuario { get; set; }
    public DateOnly CreatedAt { get; set; }
}
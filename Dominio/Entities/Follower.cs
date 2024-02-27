namespace Dominio.Entities;

public class Follower : BaseEntity
{
    public int IdUser { get; set; }
    public Usuario Usuario { get; set; }
    public DateOnly CreatedAt { get; set; }
}
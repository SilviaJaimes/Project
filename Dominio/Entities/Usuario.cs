namespace Dominio.Entities;

public class Usuario : BaseEntity
{
    public string Nombre { get; set; }
    public string CorreoElectronico { get; set; }
    public string Contraseña { get; set; }

    public ICollection<RolUsuario> RolUsuarios { get; set; } 
    public ICollection<Rol> Roles { get; set; }  = new HashSet<Rol>();
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();
    public ICollection<Follower> Followers { get; set; }
    public ICollection<Like> Likes { get; set; }
    public ICollection<Post> Posts { get; set; }
    public ICollection<Comment> Comments { get; set; }
}
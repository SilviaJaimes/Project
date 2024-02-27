namespace Dominio.Interfaces;

public interface IUnitOfWork
{
        IRol Roles { get; }
        IUsuario Usuarios { get; }
        IComment Comments { get; }
        IFollower Followers { get; }
        ILike Likes { get; }
        IPost Posts { get; }
        Task<int> SaveAsync();
}
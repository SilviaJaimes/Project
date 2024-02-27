using Aplicacion.Repository;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApiContext _context;
    private RolRepository _roles;
    private UsuarioRepository _usuarios;
    private CommentRepository _comments;
    private FollowerRepository _followers;
    private LikeRepository _likes;
    private PostRepository _posts;

    public UnitOfWork(ApiContext context)
    {
        _context = context;
    }

    public IRol Roles
    {
        get
        {
            if (_roles == null)
            {
                _roles = new RolRepository(_context);
            }
            return _roles;
        }
    }

    public IUsuario Usuarios
    {
        get
        {
            if (_usuarios == null)
            {
                _usuarios = new UsuarioRepository(_context);
            }
            return _usuarios;
        }
    }

    public IComment Comments
    {
        get
        {
            if (_comments == null)
            {
                _comments = new CommentRepository(_context);
            }
            return _comments;
        }
    }

    public IFollower Followers
    {
        get
        {
            if (_followers == null)
            {
                _followers = new FollowerRepository(_context);
            }
            return _followers;
        }
    }

    public ILike Likes
    {
        get
        {
            if (_likes == null)
            {
                _likes = new LikeRepository(_context);
            }
            return _likes;
        }
    }

    public IPost Posts
    {
        get
        {
            if (_posts == null)
            {
                _posts = new PostRepository(_context);
            }
            return _posts;
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }
    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
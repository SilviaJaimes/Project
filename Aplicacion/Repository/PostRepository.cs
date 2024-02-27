using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class PostRepository : GenericRepository<Post>, IPost
{
    private readonly ApiContext _context;

    public PostRepository(ApiContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Post>> GetAllAsync()
    {
        return await _context.Posts
            .ToListAsync();
    }

    public override async Task<Post> GetByIdAsync(int id)
    {
        return await _context.Posts
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}
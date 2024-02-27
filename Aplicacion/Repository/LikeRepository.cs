using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class LikeRepository : GenericRepository<Like>, ILike
{
    private readonly ApiContext _context;

    public LikeRepository(ApiContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Like>> GetAllAsync()
    {
        return await _context.Likes
            .ToListAsync();
    }

    public override async Task<Like> GetByIdAsync(int id)
    {
        return await _context.Likes
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}
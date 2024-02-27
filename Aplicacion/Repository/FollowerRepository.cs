using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class FollowerRepository : GenericRepository<Follower>, IFollower
{
    private readonly ApiContext _context;

    public FollowerRepository(ApiContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Follower>> GetAllAsync()
    {
        return await _context.Followers
            .ToListAsync();
    }

    public override async Task<Follower> GetByIdAsync(int id)
    {
        return await _context.Followers
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}
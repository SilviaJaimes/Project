using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class CommentRepository : GenericRepository<Comment>, IComment
{
    private readonly ApiContext _context;

    public CommentRepository(ApiContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Comment>> GetAllAsync()
    {
        return await _context.Comments
            .ToListAsync();
    }

    public override async Task<Comment> GetByIdAsync(int id)
    {
        return await _context.Comments
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}
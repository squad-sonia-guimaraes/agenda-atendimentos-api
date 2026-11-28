using AgendaAtendimentos.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaAtendimentos.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Expediente> Expedientes { get; set; }
}
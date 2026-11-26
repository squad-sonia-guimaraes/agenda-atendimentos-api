using Microsoft.EntityFrameworkCore;
using AgendaAtendimentos.Models;

namespace AgendaAtendimentos.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<Cliente> Clientes { get; set; }
}
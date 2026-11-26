using Microsoft.EntityFrameworkCore;
using AgendaAtendimentos.Data;
using AgendaAtendimentos.Models;
using AgendaAtendimentos.Repositories.Interfaces;

namespace AgendaAtendimentos.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly AppDbContext _db;

    public ClienteRepository(AppDbContext db)
    {
        _db = db;
    }

    public Task<List<Cliente>> ListarTodosAsync(int profissionalId)
    {
        return _db.Clientes
            .Where(c => c.ProfissionalId == profissionalId)
            .ToListAsync();
    }

    public Task<Cliente?> BuscarPorIdAsync(int clienteId, int profissionalId)
    {
        return _db.Clientes
            .FirstOrDefaultAsync(c => c.ClienteId == clienteId && c.ProfissionalId == profissionalId);
    }

    public async Task CadastrarAsync(Cliente cliente)
    {
        await _db.Clientes.AddAsync(cliente);
    }

    public void Atualizar(Cliente cliente)
    {
        _db.Clientes.Update(cliente);
    }

    public void Excluir(Cliente cliente)
    {
        _db.Clientes.Remove(cliente);
    }

    public Task SalvarAsync()
    {
        return _db.SaveChangesAsync();
    }
}
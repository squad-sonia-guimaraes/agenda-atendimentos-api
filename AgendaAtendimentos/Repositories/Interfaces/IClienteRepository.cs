using AgendaAtendimentos.Models;

namespace AgendaAtendimentos.Repositories.Interfaces;

public interface IClienteRepository
{
    // Para que cada profissional visualize somente seus próprios dados
    Task<List<Cliente>> ListarTodosAsync(int profissionalId); // Listar clientes de uma profissional 
    Task<Cliente?> BuscarPorIdAsync(int clienteId, int profissionalId); // Buscar cliente por ID e profissional
    Task CadastrarAsync(Cliente cliente); // Adicionar um novo cliente
    void Atualizar(Cliente cliente); // Alterar um cliente
    void Excluir(Cliente cliente); // Excluir um cliente
    Task SalvarAsync();
}
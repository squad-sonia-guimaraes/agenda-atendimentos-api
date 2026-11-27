using AgendaAtendimentos.DTOs;

namespace AgendaAtendimentos.Services.Interfaces;

public interface IClienteService
{
    Task<ClienteResponse> CadastrarAsync(
        CriarClienteRequest request,
        int profissionalId
    );

    Task<List<ClienteResponse>> ListarTodosAsync(
        int profissionalId
    );

    Task<ClienteResponse?> BuscarPorIdAsync(
        int clienteId,
        int profissionalId
    );

    Task<ClienteResponse?> AtualizarAsync(
        int clienteId,
        AtualizarClienteRequest request,
        int profissionalId
    );

    Task<bool> ExcluirAsync(
        int clienteId,
        int profissionalId
    );
}
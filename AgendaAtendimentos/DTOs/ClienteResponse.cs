namespace AgendaAtendimentos.DTOs;

public class ClienteResponse
{
    public int ClienteId { get; set; }

    public string NomeCliente { get; set; } = string.Empty;

    public string Telefone { get; set; } = string.Empty;
}
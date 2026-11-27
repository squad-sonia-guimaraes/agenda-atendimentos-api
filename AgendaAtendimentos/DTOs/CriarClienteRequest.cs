using System.ComponentModel.DataAnnotations;

namespace AgendaAtendimentos.DTOs;

public class CriarClienteRequest
{
    [Required(ErrorMessage = "O nome do cliente é um item obrigatório.")]
    [StringLength(100, MinimumLength = 2)]
    public string NomeCliente { get; set; } = string.Empty;

    [Required(ErrorMessage = "O telefone é um item obrigatório.")]
    public string Telefone { get; set; } = string.Empty;
}
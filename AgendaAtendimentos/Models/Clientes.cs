using System.ComponentModel.DataAnnotations;

namespace AgendaAtendimentos.Models;

public class Cliente
{
    [Key]
    public int ClienteId { get; set; }

    public int ProfissionalId { get; set; }

    // TODO: Configurar o relacionamento com Profissional quando estiver disponível
    // public Profissional Profissional { get; set; } = null!;

    [Required(ErrorMessage = "O nome do cliente é um campo obrigatório.")]
    [StringLength(100, MinimumLength = 2)]
    public string NomeCliente { get; set; } = string.Empty;

    [Required(ErrorMessage = "O telefone é um campo obrigatório.")]
    public string Telefone { get; set; } = string.Empty;

    // TODO: Integrar o relacionamento com Agendamento após a criação pela Dev 5
    // public List<Agendamento> Agendamentos { get; set; } = new();
}
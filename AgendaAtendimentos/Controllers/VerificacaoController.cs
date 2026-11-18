using Microsoft.AspNetCore.Mvc;

namespace AgendaAtendimentos.Controllers;

[ApiController]
[Route("api/verificacao")]
public class VerificacaoController : ControllerBase
{
    [HttpGet]
    public IActionResult Verificar()
    {
        return Ok(new
        {
            Status = "OK",
            Mensagem = "API Agenda de Atendimentos funcionando."
        });
    }
}
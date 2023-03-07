using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class IntegracoesController : ControllerBase
{
    private readonly IMediator _mediator;

    public IntegracoesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Executar()
    {
        return Ok(await _mediator.Send(new ExecutarIntegracaoCommand()));
    }
}
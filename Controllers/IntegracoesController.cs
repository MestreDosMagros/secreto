using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class IntegracoesController : ControllerBase
{
    public IntegracoesController()
    {
    }

    [HttpPost]
    public IActionResult Executar()
    {
        throw new NotImplementedException();
    }
}
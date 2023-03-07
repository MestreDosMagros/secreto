using MediatR;

namespace SeeSharp.Application.Handlers;

public class ExecutarIntegracaoCommandHandler : IRequestHandler<ExecutarIntegracaoCommand, bool>
{
    private readonly IMediator _mediator;
    private readonly IIntegracoesService _integracoesService;

    public ExecutarIntegracaoCommandHandler(IIntegracoesService integracoesService, IMediator mediator)
    {
        this._mediator = mediator;
        this._integracoesService = integracoesService;
    }

    public async Task<bool> Handle(ExecutarIntegracaoCommand request, CancellationToken cancellationToken)
    {
        var resultado = _integracoesService.Executar();

        // TODO: implementar logica de validacao do retorno da integracao


        // TODO: Gerar evento para informar integracao completa
        
        
        return true;
    }
}

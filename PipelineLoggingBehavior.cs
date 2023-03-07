using MediatR;

public class PipelineLoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly ILogger<PipelineLoggingBehavior<TRequest, TResponse>> _logger;

    public PipelineLoggingBehavior(ILogger<PipelineLoggingBehavior<TRequest, TResponse>> logger)
    {
        _logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Handling {0}", typeof(TRequest).Name);

        var response = await next();

        _logger.LogInformation("Finished handling {0} with return type {1}", typeof(TRequest).Name, typeof(TResponse).Name);

        return response;
    }
}
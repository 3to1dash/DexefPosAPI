using DataAccess.Infrastructure.Persistence;
using MediatR;

namespace DXPOS.Common.Behaviours;

public class TransactionBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly DxdbContext _dbContext;
    private readonly ILogger<TransactionBehaviour<TRequest, TResponse>> _logger;

    public TransactionBehaviour(
        DxdbContext dbContext,
        ILogger<TransactionBehaviour<TRequest, TResponse>> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        try
        {
            await _dbContext.BeginTransactionAsync();
            var response = await next();
            await _dbContext.CommitTransactionAsync();

            return response;
        }
        catch (Exception)
        {
            _logger.LogError("Request failed: Rolling back all the changes made to the Context");

            await _dbContext.RollbackTransaction();
            throw;
        }
    }
}
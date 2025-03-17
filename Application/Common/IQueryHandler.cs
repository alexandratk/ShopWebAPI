using MediatR;

namespace Application.Common
{
    public interface IQueryHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
    }
}

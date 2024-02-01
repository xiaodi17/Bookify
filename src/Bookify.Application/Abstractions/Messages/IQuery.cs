using Bookify.Domain.Abstractions;
using MediatR;

namespace Bookify.Application.Abstractions.Messages;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{

}
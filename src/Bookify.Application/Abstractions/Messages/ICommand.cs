using Bookify.Domain.Abstractions;
using MediatR;

namespace Bookify.Application.Abstractions.Messages;

public interface ICommand : IRequest<Result>, IBaseCommand
{
}

public interface ICommand<TReponse> : IRequest<Result<TReponse>>, IBaseCommand
{
}

public interface IBaseCommand
{
}

using Bookify.Application.Abstractions.Messages;

namespace Bookify.Application.Users;

public sealed record RegisterUserCommand(
    string Email,
    string FirstName,
    string LastName,
    string Password) : ICommand<Guid>;
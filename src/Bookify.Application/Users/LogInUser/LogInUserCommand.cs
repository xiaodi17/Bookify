using Bookify.Application.Abstractions.Messages;

namespace Bookify.Application.Users.LogInUser;

public sealed record LogInUserCommand(string Email, string Password)
    : ICommand<AccessTokenResponse>;
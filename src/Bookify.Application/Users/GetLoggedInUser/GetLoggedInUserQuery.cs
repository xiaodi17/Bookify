using Bookify.Application.Abstractions.Messages;

namespace Bookify.Application.Users.GetLoggedInUser;

public sealed record GetLoggedInUserQuery : IQuery<UserResponse>;
using Bookify.Application.Users;
using Bookify.Domain.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authentication.BearerToken;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookify.Api.Controllers.Users;

[ApiController]
[Route("api/v{version:apiVersion}/users")]
public class UsersController : ControllerBase
{
    private readonly ISender _sender;

    public UsersController(ISender sender)
    {
        _sender = sender;
    }


    [AllowAnonymous]
    [HttpPost("register")]
    public async Task<IActionResult> Register(
        RegisterUserRequest request,
        CancellationToken cancellationToken)
    {
        var command = new RegisterUserCommand(
            request.Email,
            request.FirstName,
            request.LastName,
            request.Password);

        Result<Guid> result = await _sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return BadRequest(result.Error);
        }

        return Ok(result.Value);
    }

    // [AllowAnonymous]
    // [HttpPost("login")]
    // public async Task<IActionResult> LogIn(
    //     LogInUserRequest request,
    //     CancellationToken cancellationToken)
    // {
    //     var command = new LogInUserCommand(request.Email, request.Password);
    //
    //     Result<AccessTokenResponse> result = await _sender.Send(command, cancellationToken);
    //
    //     if (result.IsFailure)
    //     {
    //         return Unauthorized(result.Error);
    //     }
    //
    //     return Ok(result.Value);
    // }
}

using System.Security.Claims;
using Blaze.Models;
using Microsoft.AspNetCore.Components.Authorization;

namespace Blaze.Services;

public class AuthenticatedUserStateProvider : AuthenticationStateProvider
{
    private readonly UserState userState;

    public AuthenticatedUserStateProvider(UserState userState)
    {
        this.userState = userState;
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        //var identity = new ClaimsIdentity(new[]
        //{
        //    new Claim(ClaimTypes.Name, "mrfibuli"),
        //}, "Fake authentication type");

        //var user = new ClaimsPrincipal(identity);

        //return Task.FromResult(new AuthenticationState(user));
        return Task.FromResult(userState.AuthenticationState);

    }
}
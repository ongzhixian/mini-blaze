using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Blaze.Models;

public class UserState
{
    public event Action? OnChange;

    private AuthenticationState authenticationState = new AuthenticationState(new ClaimsPrincipal());

    public AuthenticationState AuthenticationState
    {
        get => authenticationState;
        set
        {
            authenticationState = value;
            NotifyStateChanged();
        }
    }

    public ClaimsPrincipal ClaimsPrincipal
    {
        get => authenticationState.User;
        set
        {
            authenticationState = new AuthenticationState(value);
            NotifyStateChanged();
        }
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
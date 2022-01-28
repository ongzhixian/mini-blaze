# Auth

## Authentication (Blazor WebAssembly authentication)

dotnet add .\Blaze\ package Microsoft.AspNetCore.Components.Authorization

Add to `_Imports.razor` file:
`Microsoft.AspNetCore.Components.Authorization`

Notes:

AuthenticationStateProvider is the underlying service.
But you don't use it directly as components are not notified automatically if the underlying authentication state data changes.

Instead use the `AuthorizeView` component or `Task<AuthenticationState>` approaches.
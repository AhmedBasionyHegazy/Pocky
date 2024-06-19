using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Pocky.WASM.Identity
{
    public class CookieAuthenticationStateProvider : AuthenticationStateProvider
    {
        private bool _autenticated;
        private readonly ClaimsPrincipal _unauhenticated = new (new ClaimsIdentity());

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            _autenticated = false;

            var user = _unauhenticated;

            return new AuthenticationState(user);
        }
    }
}

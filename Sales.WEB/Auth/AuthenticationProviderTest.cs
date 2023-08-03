using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Sales.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonimous = new ClaimsIdentity();
            var brandUser = new ClaimsIdentity(new List<Claim>
        {
            new Claim("FirstName", "Sebastián"),
            new Claim("LastName", "Brand"),
            new Claim(ClaimTypes.Name, "brand@yopmail.com"),
            new Claim(ClaimTypes.Role, "Admin")
        },

                authenticationType: "test");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(brandUser)));

        }
    }
}

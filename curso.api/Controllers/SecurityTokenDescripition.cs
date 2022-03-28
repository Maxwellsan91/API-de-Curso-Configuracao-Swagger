using Microsoft.IdentityModel.Tokens;
using System;
using System.Security.Claims;

namespace curso.api.Controllers
{
    internal class SecurityTokenDescripition
    {
        public ClaimsIdentity Subject { get; set; }
        public DateTime Expires { get; internal set; }
        public SigningCredentials SigningCredentials { get; internal set; }
    }
}
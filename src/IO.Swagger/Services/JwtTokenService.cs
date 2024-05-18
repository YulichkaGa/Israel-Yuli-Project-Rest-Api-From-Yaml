using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;

namespace IO.Swagger.Services
{
    ///<Summary>
    /// JwtTokenService
    ///</Summary>
    public class JwtTokenService : IJwtTokenService
    {
        private readonly IConfiguration _configuration;
        ///<Summary>
        /// JwtTokenService
        ///</Summary>
        public JwtTokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        ///<Summary>
        /// GenerateToken
        ///</Summary>
        public string GenerateToken(string username)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var key = Encoding.ASCII.GetBytes(jwtSettings["Key"]);

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                new Claim(ClaimTypes.Name, username)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                Issuer = jwtSettings["Issuer"],
                Audience = jwtSettings["Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}

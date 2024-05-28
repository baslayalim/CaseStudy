using Azure.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace CaseStudy.Api.CustomJwt
{
    public class CustomJwtHelper : ICustomJwtHelper
    {
        private DateTime _accessTokenExpiration;

        public static string Audience = "localhost";
        public static string Issuer = "localhost";
        private int AccessTokenExpiration = 2;
        public int RefreshTokenExpiration = 4;
        public static string SecurityKey = "s%01mtxc&e+u$e)1fmj0ue$fp%!p$zgmilw+wgg#=qk%d_d0yt";

        public CustomJwtAccessToken CreateToken(CustomJwtData _customJwtData)
        {
            _accessTokenExpiration = DateTime.UtcNow.AddMinutes(AccessTokenExpiration);
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecurityKey));
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var jwt = CreateJwtSecurityToken(_customJwtData, signingCredentials);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new CustomJwtAccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration,
                RefreshToken = _customJwtData.RefreshToken,
                RefreshTokenExpiration = _customJwtData.RefreshTokenEndDate
            };
        }
        private JwtSecurityToken CreateJwtSecurityToken(CustomJwtData _customJwtData, SigningCredentials signingCredentials)
        {
            var jwt = new JwtSecurityToken(
                issuer: Issuer,
                audience: Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.UtcNow,
                claims: SetClaims(_customJwtData),
                signingCredentials: signingCredentials
            );
            return jwt;
        }

        private IEnumerable<Claim> SetClaims(CustomJwtData _customJwtData)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, _customJwtData.Id.ToString()),
                new Claim(ClaimTypes.Name, _customJwtData.Name ?? string.Empty),
                new Claim(ClaimTypes.Email, _customJwtData.Email ?? string.Empty),
                new Claim("UserName", _customJwtData.UserName ?? string.Empty),
                new Claim("Description", _customJwtData.Description ?? string.Empty)
            };

            if (_customJwtData.Roles != null && _customJwtData.Roles.Any())
                _customJwtData.Roles.ForEach(role => claims.Add(new Claim(ClaimTypes.Role, role)));
            return claims;
        }

        public string CreateRefreshToken()
        {
            byte[] number = new byte[32];
            using RandomNumberGenerator random = RandomNumberGenerator.Create();
            random.GetBytes(number);
            return Convert.ToBase64String(number);
        }

        public static CustomJwtData JwtDataLoad(System.Security.Claims.ClaimsIdentity claimsIdentity)
        {
            return new CustomJwtData()
            {
                Id = Guid.Parse(claimsIdentity.Claims.First(z => z.Type == ClaimTypes.NameIdentifier).Value),
                Name = claimsIdentity.Claims.First(z => z.Type == ClaimTypes.Name).Value,
                Email = claimsIdentity.Claims.First(z => z.Type == ClaimTypes.Email).Value,
                UserName = claimsIdentity.Claims.First(z => z.Type == "UserName").Value,
                Description = claimsIdentity.Claims.First(z => z.Type == "Description").Value,
                Roles = claimsIdentity.Claims.Where(z => z.Type == ClaimTypes.Role).Select(z => z.Value).ToList()
            };
        }
    }
}

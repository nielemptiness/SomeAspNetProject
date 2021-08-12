﻿using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Store.Core.Host.Authorization.JWT
{
    public class AuthManager : IAuthManager
    {
        private readonly JwtConfig _config;

        public AuthManager(JwtConfig config)
        {
            _config = config;
        }

        public string GenerateToken(string username, Claim[] claims)
        {
            var token = new JwtSecurityToken(
                _config.Issuer,
                "",
                claims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddMinutes(_config.AccessTokenExpiration),
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config.Secret)), SecurityAlgorithms.HmacSha256Signature)
            );

            var accessToken = new JwtSecurityTokenHandler().WriteToken(token);

            return accessToken;
        }
    }
}
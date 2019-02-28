using System;
using Lethon.Models;
using Lethon.Services;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace Lethon.Tests.Services
{
    public class TokenServiceTests
    {
        [Fact]
        public void VerifyToken()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var requestModel = new VerifyTokenRequest()
            {
                Secret = config["SecretKey"],
                Token = "9a26c43b-7015-41e8-84c1-960c786dfe35",
                Hashes = 1024
            };

            var tokenService = new TokenService();

            var responseModel = tokenService.VerifyTokenAsync(requestModel).Result;
        }
    }
}

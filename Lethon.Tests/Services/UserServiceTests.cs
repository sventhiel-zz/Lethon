using System;
using Microsoft.Extensions.Configuration;
using Xunit;
using Lethon.Models;
using Lethon.Services;

namespace Lethon.Tests.Services
{
    public class UserServiceTests
    {
        [Fact]
        public void Balance()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var requestModel = new BalanceRequest()
            {
                Secret = config["SecretKey"],
                Name = "m6thsv2@googlemail.com"
            }; 

            var userService = new UserService();

            var responseModel = userService.BalanceAsync(requestModel).Result;
        }
    }
}

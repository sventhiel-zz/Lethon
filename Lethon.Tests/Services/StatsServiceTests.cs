using System;
using Microsoft.Extensions.Configuration;
using Xunit;
using Lethon.Models;
using Lethon.Services;

namespace Lethon.Tests.Services
{
    public class StatsServiceTests
    {
        [Fact]
        public void Payout()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var requestModel = new PayoutRequest()
            {
                Secret = config["SecretKey"]
            };

            var statsService = new StatsService();

            var responseModel = statsService.PayoutAsync(requestModel).Result;
        }

        [Fact]
        public void History()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var requestModel = new HistoryRequest()
            {
                Secret = config["SecretKey"]
            };

            var statsService = new StatsService();

            var responseModel = statsService.HistoryAsync(requestModel).Result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Lethon.Interfaces;
using Lethon.Models;
using Microsoft.Extensions.Configuration;

namespace Lethon.Services
{
    public class StatsService : BaseService, IStatsService
    {
        public async Task<List<HistoryResponse>> HistoryAsync(HistoryRequest requestModel)
        {
            var serviceURL = $"{BaseURL}/stats/history";

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, serviceURL) { Content = new FormUrlEncodedContent(requestModel.ToDictionary()) };

            using (var response = await client.SendAsync(request))
            {
                var message = await response.Content.ReadAsStringAsync();

                // ToDo:    split the message in separate "json" pieces and 
                //          then transform them into single class instances
                var responseModel = Newtonsoft.Json.JsonConvert.DeserializeObject(;

                return responseModel;
            }
        }
    }
}

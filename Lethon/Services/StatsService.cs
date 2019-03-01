using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Lethon.Interfaces;
using Lethon.Models;
using Microsoft.Extensions.Configuration;

namespace Lethon.Services
{
    /// <summary>
    /// Stats service.
    /// </summary>
    public class StatsService : BaseService, IStatsService
    {
#if DEBUG
        public async Task<HistoryResponse> HistoryAsync(HistoryRequest requestModel)
        {
            var serviceURL = $"{BaseURL}/stats/history";

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, serviceURL) { Content = new FormUrlEncodedContent(requestModel.ToDictionary()) };

            using (var response = await client.SendAsync(request))
            {
                var message = await response.Content.ReadAsStringAsync();

                // ToDo:    split the message in separate "json" pieces and 
                //          then transform them into single class instances
                var responseModel = Newtonsoft.Json.JsonConvert.DeserializeObject<HistoryResponse>(message);

                return responseModel;
            }
        }
#endif

        /// <summary>
        /// Payouts the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="requestModel">Request model.</param>
        public async Task<PayoutResponse> PayoutAsync(PayoutRequest requestModel)
        {
            var serviceURL = $"{BaseURL}/stats/payout";

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, serviceURL) { Content = new FormUrlEncodedContent(requestModel.ToDictionary()) };

            using (var response = await client.SendAsync(request))
            {
                var message = await response.Content.ReadAsStringAsync();
                var responseModel = Newtonsoft.Json.JsonConvert.DeserializeObject<PayoutResponse>(message);

                return responseModel;
            }
        }
    }
}

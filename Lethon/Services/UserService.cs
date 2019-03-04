using System;
using System.Net.Http;
using System.Threading.Tasks;
using Lethon.Interfaces;
using Lethon.Models;

namespace Lethon.Services
{
    public class UserService : BaseService, IUserService
    {
        public async Task<BalanceResponse> BalanceAsync(BalanceRequest requestModel)
        {
            var serviceURL = $"{BaseURL}/user/balance";

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, serviceURL) { Content = new FormUrlEncodedContent(requestModel.ToDictionary()) };

            using (var response = await client.SendAsync(request))
            {
                var message = await response.Content.ReadAsStringAsync();
                var responseModel = Newtonsoft.Json.JsonConvert.DeserializeObject<BalanceResponse>(message);

                return responseModel;
            }
        }

        public Task<ListResponse> ListAsync(ListRequest requestModel)
        {
            throw new NotImplementedException();
        }

        public Task<TopResponse> TopAsync(TopRequest requestModel)
        {
            throw new NotImplementedException();
        }
    }
}

using System.Threading.Tasks;
using Lethon.Interfaces;
using Lethon.Models;
using System.Net.Http;
using Microsoft.Extensions.Configuration;

namespace Lethon.Services
{
    /// <summary>
    /// Token service.
    /// </summary>
    public class TokenService : BaseService, ITokenService
    {
        /// <summary>
        /// Verifies the token.
        /// </summary>
        /// <returns>The token.</returns>
        /// <param name="requestModel">Request model.</param>
        public async Task<VerifyTokenResponse> VerifyTokenAsync(VerifyTokenRequest requestModel)
        {
            var serviceURL = $"{BaseURL}/token/verify";

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, serviceURL) { Content = new FormUrlEncodedContent(requestModel.ToDictionary()) };

            using (var response = await client.SendAsync(request))
            {
                var message = await response.Content.ReadAsStringAsync();
                var responseModel = Newtonsoft.Json.JsonConvert.DeserializeObject<VerifyTokenResponse>(message);

                return responseModel;
            }
        }
    }
}

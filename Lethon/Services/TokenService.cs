using System.Threading.Tasks;
using Lethon.Interfaces;
using Lethon.Models;
using System.Net.Http;

namespace Lethon.Services
{
    /// <summary>
    /// Token service.
    /// </summary>
    public class TokenService : ITokenService
    {
        /// <summary>
        /// Verifies the token.
        /// </summary>
        /// <returns>The token.</returns>
        /// <param name="requestModel">Request model.</param>
        public async Task<VerifyTokenResponse> VerifyToken(VerifyTokenRequest requestModel)
        {
            var serviceURL = "https://api.crypto-loot.com/token/verify";

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

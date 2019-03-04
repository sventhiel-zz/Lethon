using System.Collections.Generic;
namespace Lethon.Models
{
    /// <summary>
    /// Verify token request.
    /// </summary>
    public class VerifyTokenRequest
    {
        public int Hashes { get; set; }
        public string Secret { get; set; }
        public string Token { get; set; }

        /// <summary>
        /// Tos the dictionary.
        /// </summary>
        /// <returns>The dictionary.</returns>
        public Dictionary<string, string> ToDictionary()
        {
            return new Dictionary<string, string> { { "secret", Secret }, { "token", Token }, { "hashes", Hashes.ToString() } };
        }

    }

    /// <summary>
    /// Verify token response.
    /// </summary>
    public class VerifyTokenResponse
    {
        public string Error { get; set; }
        public int? Hashes { get; set; }
        public bool Success { get; set; }


    }
}

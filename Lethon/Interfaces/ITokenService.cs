using System;
using System.Threading.Tasks;
using Lethon.Models;

namespace Lethon.Interfaces
{
    /// <summary>
    /// Token service.
    /// </summary>
    public interface ITokenService
    {
        /// <summary>
        /// Verifies the token.
        /// </summary>
        /// <returns>The token.</returns>
        /// <param name="request">Request.</param>
        Task<VerifyTokenResponse> VerifyToken(VerifyTokenRequest request);
    }
}

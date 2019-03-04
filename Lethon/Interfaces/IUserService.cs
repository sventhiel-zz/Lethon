using System.Threading.Tasks;
using Lethon.Models;

namespace Lethon.Interfaces
{
    /// <summary>
    /// User service.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Balances the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="requestModel">Request model.</param>
        Task<BalanceResponse> BalanceAsync(BalanceRequest requestModel);

        /// <summary>
        /// Tops the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="requestModel">Request model.</param>
        Task<TopResponse> TopAsync(TopRequest requestModel);

        /// <summary>
        /// Lists the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="requestModel">Request model.</param>
        Task<ListResponse> ListAsync(ListRequest requestModel);
    }
}

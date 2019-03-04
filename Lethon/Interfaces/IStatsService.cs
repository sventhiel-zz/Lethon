using System.Threading.Tasks;
using Lethon.Models;
namespace Lethon.Interfaces
{
    /// <summary>
    /// Stats service.
    /// </summary>
    public interface IStatsService
    {
        /// <summary>
        /// Histories the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="requestModel">Request model.</param>
        Task<HistoryResponse> HistoryAsync(HistoryRequest requestModel);

        /// <summary>
        /// Payouts the async.
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="requestModel">Request model.</param>
        Task<PayoutResponse> PayoutAsync(PayoutRequest requestModel);
    }
}

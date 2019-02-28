using System;
using System.Threading.Tasks;
using Lethon.Models;

namespace Lethon.Interfaces
{
    public interface IUserService
    {
        Task<BalanceResponse> BalanceAsync(BalanceRequest requestModel);
    }
}

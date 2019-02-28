using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lethon.Models;
namespace Lethon.Interfaces
{
    public interface IStatsService
    {
        Task<List<HistoryResponse>> HistoryAsync(HistoryRequest requestModel);
    }
}

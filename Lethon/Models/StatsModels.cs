using System.Collections.Generic;

namespace Lethon.Models
{
    public class HistoryRequest
    {
        public string Secret { get; set; }

        public Dictionary<string, string> ToDictionary()
        {
            return new Dictionary<string, string> { { "secret", Secret } };
        }
    }

    public class HistoryResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public List<HistoryEntry> History { get; set; }

        public static HistoryResponse ToHistoryResponse(string message)
        {
            return new HistoryResponse()
            {

            };
        }
    }

    public class HistoryEntry
    {
        public string Hashes { get; set; }
        public string Hashrate { get; set; }
        public string Synctime { get; set; }
    }

    /// <summary>
    /// Payout request.
    /// </summary>
    public class PayoutRequest
    {
        public string Secret { get; set; }

        /// <summary>
        /// Tos the dictionary.
        /// </summary>
        /// <returns>The dictionary.</returns>
        public Dictionary<string, string> ToDictionary()
        {
            return new Dictionary<string, string> { { "secret", Secret } };
        }
    }

    /// <summary>
    /// Payout response.
    /// </summary>
    public class PayoutResponse
    {
        public bool Success { get; set; } = true;
        public string Error { get; set; }
        public long Diff { get; set; }
        public double Value { get; set; }
        public double Payout { get; set; }
        public double PayoutPer1MHashes { get; set; }
        public long Synctime { get; set; }
    }
}

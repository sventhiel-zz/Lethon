using System.Collections.Generic;

namespace Lethon.Models
{
    public class BalanceRequest
    {
        public string Name { get; set; }
        public string Secret { get; set; }

        public Dictionary<string, string> ToDictionary()
        {
            return new Dictionary<string, string> { { "secret", Secret }, { "name", Name } };
        }
    }

    public class BalanceResponse
    {
        public bool Success { get; set; }
        public string Name { get; set; }
        public int Total { get; set; }
        public int Withdrawn { get; set; }
        public int Balance { get; set; }
        public string Error { get; set; }
    }

    public class ListRequest
    {
        public string Secret { get; set; }
        public int Count { get; set; }
        public Order Order { get; set; }
    }

    public enum Order
    {
        // ToDo:    add proper mechanism to transform the values
        //          into real text with small letters only.
        //total, balance or withdrawn
        Total,
        Balance,
        Withdrawn
    }

    public class ListResponse
    {

    }

    public class TopRequest
    {

    }

    public class TopResponse
    {

    }
}

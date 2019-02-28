using System;
using System.Collections.Generic;

namespace Lethon.Models
{
    public class LinkRequest
    {
        public string Secret { get; set; }
        public string URL { get; set; }
        public int Hashes { get; set; }

        public Dictionary<string, string> ToDictionary()
        {
            return new Dictionary<string, string> { { "secret", Secret }, { "url", URL }, { "hashes", Hashes.ToString() } };
        }
    }

    public class LinkResponse
    {
        public string Error { get; set; }
        public string URL { get; set; }
        public bool Success { get; set; }
    }
}

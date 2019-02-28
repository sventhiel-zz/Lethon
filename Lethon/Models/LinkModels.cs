using System;
using System.Collections.Generic;

namespace Lethon.Models
{
    /// <summary>
    /// Link request.
    /// </summary>
    public class LinkRequest
    {
        public string Secret { get; set; }
        public string URL { get; set; }
        public int Hashes { get; set; }

        /// <summary>
        /// Tos the dictionary.
        /// </summary>
        /// <returns>The dictionary.</returns>
        public Dictionary<string, string> ToDictionary()
        {
            return new Dictionary<string, string> { { "secret", Secret }, { "url", URL }, { "hashes", Hashes.ToString() } };
        }
    }

    /// <summary>
    /// Link response.
    /// </summary>
    public class LinkResponse
    {
        public string Error { get; set; }
        public string URL { get; set; }
        public bool Success { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyPrivate
{
    class Auth
    {
        public class Response
        {
            public string clientId { get; set; } = "";
            public string accessToken { get; set; } = "";
            public long accessTokenExpirationTimestampMs { get; set; }
            public bool isAnonymous { get; set; }
        }



        public static async Task<Response> GetAuth()
        {
            HttpClient tmpClient = new();

            //Spotify do not allow requests without a user agent
            tmpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

            Response? response = await tmpClient.GetFromJsonAsync<Response>("https://open.spotify.com/get_access_token?reason=transport&productType=web_player");

            if (response == null)
                throw new Exception("Failed to fetch authorization token");

            return response;
        }
    }
}
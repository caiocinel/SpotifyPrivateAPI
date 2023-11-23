
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace SpotifyPrivate
{
    class API
    {
        private const string baseURL = "https://api-partner.spotify.com/pathfinder/v1/query?";
        private string? operationName = null;
        private string? variables = null;
        private string? extensions = null;
        private string token;
        private HttpClient client = new HttpClient();

        private string GetQuery(string operationName, string variables, string extensions)
        {
            return "operationName=" + operationName + "&variables=" + variables + "&extensions=" + extensions;
        }

        private async Task<SpotifyToken> FetchAuthorization()
        {
            HttpClient tmpClient = new();

            //Spotify do not allow requests without a user agent
            tmpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) " +
                           "AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

            Task<SpotifyToken?> response = tmpClient.GetFromJsonAsync<SpotifyToken>("https://open.spotify.com/get_access_token?reason=transport&productType=web_player");

            if (response == null || response.Result == null)
                throw new Exception("Failed to fetch authorization token");

            return response.Result;
        }

        public API(string? token = null)
        {
            if (token != null)
            {
                this.token = token;
                return;
            }

            var auth = FetchAuthorization().Result;

            this.token = auth.accessToken;
        }


        public async Task<Track.Response> GetTrackInfo(string trackID)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            operationName = "getTrack";
            variables = "%7B%22uri%22%3A%22spotify%3Atrack%3A" + trackID + "%22%2C%22locale%22%3A%22intl-pt%22%7D";
            extensions = @"{
                ""persistedQuery"": {
                    ""version"": 1,
                    ""sha256Hash"": ""e101aead6d78faa11d75bec5e36385a07b2f1c4a0420932d374d89ee17c70dd6""
                }
            }";

            Track.Response response =  await client.GetFromJsonAsync<Track.Response>(baseURL + GetQuery(operationName, variables, extensions));

            if (response == null)
                throw new Exception("Failed to fetch track info");

            return response;
        }


        public async Task<Artist.Response> GetArtistInfo(string artistID)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            operationName = "queryArtistOverview";
            variables = "%7B%22uri%22%3A%22spotify%3Aartist%3A" + artistID + "%22%2C%22locale%22%3A%22intl-pt%22%2C%22includePrerelease%22%3Atrue%7D";
            extensions = @"{
                ""persistedQuery"": {
                    ""version"": 1,
                    ""sha256Hash"": ""9bd4b303bbc7e5a7c008b90197edb7c79c6d8d9c96e9d4e6ac7dfaabf71a9e58""
                }
            }";

            Artist.Response response = await client.GetFromJsonAsync<Artist.Response>(baseURL + GetQuery(operationName, variables, extensions));

            if (response == null)
                throw new Exception("Failed to fetch track info");

            return response;
        }

        class SpotifyToken
        {
            public string clientId { get; set; } = "";
            public string accessToken { get; set; } = "";
            public long accessTokenExpirationTimestampMs { get; set; }
            public bool isAnonymous { get; set; }
        }
    }
}
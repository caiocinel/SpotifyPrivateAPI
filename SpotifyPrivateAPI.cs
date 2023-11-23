
using System.Net.Http.Headers;
using System.Net.Http.Json;

class SpotifyPrivateAPI
{
    private string baseURL = "https://api-partner.spotify.com/pathfinder/v1/query?";
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
        HttpClient tmpClient = new HttpClient();

        SpotifyToken? result = null;

        try {
            result = await tmpClient.GetFromJsonAsync<SpotifyToken>("https://open.spotify.com/get_access_token?reason=transport&productType=web_player");
        } catch (Exception e)
        {
            Console.WriteLine(e);
        }


        if (result == null)
        {
            throw new Exception("Failed to fetch authorization token");
        }

        return result;

    }

    public SpotifyPrivateAPI(string? token = null)
    {
        if (token != null)
        {
            this.token = token;
            return;
        }

        var auth = FetchAuthorization().Result;

        this.token = auth.accessToken;
    }


    public async Task<string> GetTrackInfo(string trackID)
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

        var data = await client.GetAsync(baseURL + GetQuery(operationName, variables, extensions));
        return data.Content.ReadAsStringAsync().Result;

    }

    class SpotifyToken
    {
        public string clientId { get; set; }
        public string accessToken { get; set; }
        public long accessTokenExpirationTimestampMs { get; set; }
        public bool isAnonymous { get; set; }
    }
}

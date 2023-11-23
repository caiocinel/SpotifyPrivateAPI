
using Newtonsoft.Json;
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
        private string? token = null;
        private HttpClient? client = null;

        public API(string? token = null) => this.token = token;

        public async Task<Track.Base> GetTrack(string trackID)
        {            
            operationName = "getTrack";

            variables = JsonConvert.SerializeObject(new {
                uri = $"spotify:track:{trackID}",
                locale = "intl-pt"
            });

            extensions = JsonConvert.SerializeObject(new
            {
                persistedQuery = new
                {
                    version = 1,
                    sha256Hash = "e101aead6d78faa11d75bec5e36385a07b2f1c4a0420932d374d89ee17c70dd6"
                }
            });
           
            Track.Base response =  await DoRequest<Track.Base>();

            return response == null ? throw new Exception("Failed to fetch track info") : response;
        }


        public async Task<Artist.Base> GetArtist(string artistID)
        {
            operationName = "queryArtistOverview";

            variables = JsonConvert.SerializeObject(new
            {
                uri = $"spotify:artist:{artistID}",
                locale = "intl-pt",
                includePrerelease = true
            });

            extensions = JsonConvert.SerializeObject(new
            {
                persistedQuery = new
                {
                    version = 1,
                    sha256Hash = "9bd4b303bbc7e5a7c008b90197edb7c79c6d8d9c96e9d4e6ac7dfaabf71a9e58"
                }
            });

            Artist.Base response = await DoRequest<Artist.Base>();

            return response == null ? throw new Exception("Failed to fetch track info") : response;
        }



        /// <summary>
        ///# Private Methods
        /// </summary>
        /// <returns></returns>

        private string GetQuery() => "operationName=" + operationName + "&variables=" + variables + "&extensions=" + extensions;

        private async Task<T> DoRequest<T>()
        {
            if (token == null)
                token = (await Auth.GetAuth()).accessToken;

            client = new();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            T? response = default;

            try
            {
                response = await client.GetFromJsonAsync<T>(baseURL + GetQuery());
            }
            catch (HttpRequestException e)
            {
                if (e.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    token = (await Auth.GetAuth()).accessToken;
                    return await DoRequest<T>();
                }

                throw new Exception("Failed to fetch track info: " + e.Message);
            }

            return response == null ? throw new Exception("Failed to fetch track info") : response;
        }


    }
}
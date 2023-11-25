
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace SpotifyPrivate
{
    class API
    {
        private const string baseURL = "https://api-partner.spotify.com/pathfinder/v1/query?";
        private string? operationName = null;
        private string? variables = null;
        private string? extensions = null;
        private string? token = null;
        private string? body = null;
        private HttpClient? client = null;
        private WebProxy? proxy = null;

        public API(string? token = null, WebProxy? proxyConfig = null) {
            this.token = token;           
            this.proxy = proxyConfig; 
        }

        public async Task<Track.Base?> GetTrack(string trackID)
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
           
            Track.Base? response =  await DoGetRequest<Track.Base?>();

            return response;
        }


        public async Task<Artist.Base?> GetArtist(string artistID)
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

            Artist.Base? response = await DoGetRequest<Artist.Base?>();

            return response;
        }

        public async Task<Playlist.Base?> GetPlaylist(string playlistID, bool fetchAllSongs = false)
        {
            operationName = "fetchPlaylist";

            variables = JsonConvert.SerializeObject(new
            {
                uri = $"spotify:playlist:{playlistID}",
                offset = 0,
                limit = 400
            });

            extensions = JsonConvert.SerializeObject(new
            {
                persistedQuery = new
                {
                    version = 1,
                    sha256Hash = "73a3b3470804983e4d55d83cd6cc99715019228fd999d51429cc69473a18789d"
                }
            });

            Playlist.Base? response = await DoGetRequest<Playlist.Base?>();

            if(response == null)
                return null;

            while ((fetchAllSongs) && (response.Data.PlaylistV2.Content.Items.Count < response.Data.PlaylistV2.Content.TotalCount))
            {
                response.Data.PlaylistV2.Content.Items.AddRange(await GetPlaylistSongsRecursive(playlistID, response.Data.PlaylistV2.Content.Items.Count));
            }

            return response;
        }

        public async Task<Album.Base?> GetAlbum(string albumId)
        {
            operationName = "getAlbum";

            variables = JsonConvert.SerializeObject(new
            {
                uri = $"spotify:album:{albumId}",
                locale = "intl-en",
                offset = 0,
                limit = 50
            });

            extensions = JsonConvert.SerializeObject(new
            {
                persistedQuery = new
                {
                    version = 1,
                    sha256Hash = "46ae954ef2d2fe7732b4b2b4022157b2e18b7ea84f70591ceb164e4de1b5d5d3"
                }
            });

            Album.Base? response = await DoGetRequest<Album.Base?>();

            return response;
        }

        public async Task<bool> AddLibrary(string uri)
        {
            operationName = "addToLibrary";

            variables = JsonConvert.SerializeObject(new
            {
                uris = new List<string> { uri },
            });

            extensions = JsonConvert.SerializeObject(new
            {
                persistedQuery = new
                {
                    version = 1,
                    sha256Hash = "656c491c3f65d9d08d259be6632f4ef1931540ebcf766488ed17f76bb9156d15"
                }
            });

            var response = await DoGetRequest<bool>();

            return response;
        }

        public async Task<bool> FollowUser(string userId)
        {
            operationName = "searchUsers";

            variables = JsonConvert.SerializeObject(new
            {
                usernames = new List<string> { userId },
            });

            extensions = JsonConvert.SerializeObject(new
            {
                persistedQuery = new
                {
                    version = 1,
                    sha256Hash = "5a467654a1b81d4a8ab2a91819d7646264bd94873b163e034896be0dbf142eb7"
                }
            });

            var response = await DoGetRequest<bool>();

            return response;
        }

        public async Task<bool> FollowUser(List<string> users)
        {
            body = JsonConvert.SerializeObject(new
            {
                variables = new
                {
                    usernames = users,
                },
                operationName = "followUsers",
                extensions = new
                {
                    persistedQuery = new
                    {
                        version = 1,
                        sha256Hash = "5a467654a1b81d4a8ab2a91819d7646264bd94873b163e034896be0dbf142eb7"
                    }
                }
            });

            var response = await DoPostRequest<bool>();

            return response;
        }

        public async Task<UserSearch.Base?> SearchUser(string searchTerm, bool fetchAllResults = false)
        {
            operationName = "searchUsers";

            variables = JsonConvert.SerializeObject(new
            {
                searchTerm = searchTerm,
                offset = 0,
                limit = 100,
                numberOfTopResults = 0,
                includeAudiobooks = false
            });

            extensions = JsonConvert.SerializeObject(new
            {
                persistedQuery = new
                {
                    version = 1,
                    sha256Hash = "f82af76fbfa6f57a45e0f013efc0d4ae53f722932a85aca18d32557c637b06c8"
                }
            });

            UserSearch.Base? response = await DoGetRequest<UserSearch.Base?>();


            while ((fetchAllResults) && (response.Data.SearchV2.Users.Items.Count < response.Data.SearchV2.Users.TotalCount))
            {
                var tempData = await SearchUserRecursive(searchTerm, response.Data.SearchV2.Users.Items.Count);

                if (tempData == null || tempData.Count == 0)
                    break;

                response.Data.SearchV2.Users.Items.AddRange(tempData);
            }



            return response;
        }

        public async Task<User.Base?> GetUser(string userID, int playlist_limit = 10, int artist_limit = 10, int episode_limit = 10, string market = "US")
        {
            string URL = $"https://spclient.wg.spotify.com/user-profile-view/v3/profile/{userID}?playlist_limit={playlist_limit}&artist_limit={artist_limit}&episode_limit={episode_limit}&market={market}";
            User.Base? response = await DoGetRequest<User.Base?>(URL);
            return response;
        }



        /// <summary>
        ///# Private Methods
        /// </summary>
        /// <returns></returns>

        private string GetQuery() {
            if (operationName == null || variables == null || extensions == null)
                return "";

            return "operationName=" + operationName + "&variables=" + variables + "&extensions=" + extensions;
        }

        private async Task<T?> DoGetRequest<T>(string? URL = null)
        {
            if (token == null)
                token = (await Auth.GetAuth()).accessToken;


            if (proxy != null)
                client = new HttpClient(new HttpClientHandler { Proxy = proxy });
            else
                client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            T ? response = default(T);

            try
            {
                //GetFromJsonAsync make lists return null
                var data = await client.GetStringAsync(URL == null ? baseURL + GetQuery() : URL);                

                if (typeof(T) == typeof(bool))
                    return (T)Convert.ChangeType(true, typeof(T));

                response = JsonConvert.DeserializeObject<T>(data);
            }
            catch (HttpRequestException e)
            {
                if (e.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    token = (await Auth.GetAuth()).accessToken;
                    return await DoGetRequest<T>(URL);
                }
            }

            return response;
        }

        private async Task<T?> DoPostRequest<T>(string? URL = null)
        {
            if (token == null)
                token = (await Auth.GetAuth()).accessToken;


            if (proxy != null)
                client = new HttpClient(new HttpClientHandler { Proxy = proxy });
            else
                client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            T? response = default(T);

            try
            {
                //GetFromJsonAsync make lists return null
                var data = await client.PostAsync(URL == null ? baseURL : URL, new StringContent(body ?? "", Encoding.UTF8, "application/json"));

                if (typeof(T) == typeof(bool))
                    return (T)Convert.ChangeType(true, typeof(T));

                response = JsonConvert.DeserializeObject<T?>(data.Content.ToString());
            }
            catch (HttpRequestException e)
            {
                if (e.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    token = (await Auth.GetAuth()).accessToken;
                    return await DoPostRequest<T>(URL);
                }
            }

            return response;
        }

        private async Task<List<Playlist.Item>> GetPlaylistSongsRecursive(string playlistId, int offset)
        {
            operationName = "fetchPlaylistContents";

            variables = JsonConvert.SerializeObject(new
            {
                uri = $"spotify:playlist:{playlistId}",
                offset = offset,
                limit = 400
            });

            extensions = JsonConvert.SerializeObject(new
            {
                persistedQuery = new
                {
                    version = 1,
                    sha256Hash = "2c5eb75bd3f267189ac2ce04b2b05dfae1ad5a42322f5c0045f7b787c8ce25ff"
                }
            });

            PlaylistContent.Base? response = await DoGetRequest<PlaylistContent.Base?>();


            if (response == null)
                return new List<Playlist.Item>();

            return response.Data.PlaylistV2.Content.Items;
        }

        private async Task<List<UserSearch.Item>> SearchUserRecursive(string searchTerm, int offset)
        {
            operationName = "searchUsers";

            variables = JsonConvert.SerializeObject(new
            {
                searchTerm = searchTerm,
                offset = offset,
                limit = 100,
                numberOfTopResults = 0,
                includeAudiobooks = false
            });

            extensions = JsonConvert.SerializeObject(new
            {
                persistedQuery = new
                {
                    version = 1,
                    sha256Hash = "f82af76fbfa6f57a45e0f013efc0d4ae53f722932a85aca18d32557c637b06c8"
                }
            });

            UserSearch.Base? response = await DoGetRequest<UserSearch.Base?>();


            if (response == null || response.Data.SearchV2 == null)
                return new List<UserSearch.Item>();

            return response.Data.SearchV2.Users.Items;
        }


        /// <summary>
        ///# Static Methods
        /// </summary>
        /// <returns></returns>

        public class Uri
        {
            public string Type;
            public string Uid;

            public Uri(string uri)
            {
                string[] uriSplit = uri.Split(':');
                Type = uriSplit[1];
                Uid = uriSplit[2];
            }
        }

        public static Uri ParseURI(string uri) => new Uri(uri);
    }
}
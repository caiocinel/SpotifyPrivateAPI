#pragma warning disable CS8618
using Newtonsoft.Json;

namespace SpotifyPrivate
{
    namespace User
    {        
        public class PublicPlaylist
        {
            [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
            public string Uri { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
            public string ImageUrl { get; set; }

            [JsonProperty("owner_name", NullValueHandling = NullValueHandling.Ignore)]
            public string OwnerName { get; set; }

            [JsonProperty("owner_uri", NullValueHandling = NullValueHandling.Ignore)]
            public string OwnerUri { get; set; }

            [JsonProperty("followers_count", NullValueHandling = NullValueHandling.Ignore)]
            public int? FollowersCount { get; set; }
        }

        public class RecentlyPlayedArtist
        {
            [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
            public string Uri { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
            public string ImageUrl { get; set; }

            [JsonProperty("followers_count", NullValueHandling = NullValueHandling.Ignore)]
            public int? FollowersCount { get; set; }
        }

        public class Base
        {
            [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
            public string Uri { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
            public string ImageUrl { get; set; }

            [JsonProperty("followers_count", NullValueHandling = NullValueHandling.Ignore)]
            public int? FollowersCount { get; set; }

            [JsonProperty("following_count", NullValueHandling = NullValueHandling.Ignore)]
            public int? FollowingCount { get; set; }

            [JsonProperty("recently_played_artists", NullValueHandling = NullValueHandling.Ignore)]
            public List<RecentlyPlayedArtist> RecentlyPlayedArtists { get; set; }

            [JsonProperty("public_playlists", NullValueHandling = NullValueHandling.Ignore)]
            public List<PublicPlaylist> PublicPlaylists { get; set; }

            [JsonProperty("total_public_playlists_count", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalPublicPlaylistsCount { get; set; }

            [JsonProperty("has_spotify_name", NullValueHandling = NullValueHandling.Ignore)]
            public bool? HasSpotifyName { get; set; }

            [JsonProperty("has_spotify_image", NullValueHandling = NullValueHandling.Ignore)]
            public bool? HasSpotifyImage { get; set; }

            [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
            public int? Color { get; set; }

            [JsonProperty("allow_follows", NullValueHandling = NullValueHandling.Ignore)]
            public bool? AllowFollows { get; set; }

            [JsonProperty("show_follows", NullValueHandling = NullValueHandling.Ignore)]
            public bool? ShowFollows { get; set; }
        }


    }
}
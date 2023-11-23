#pragma warning disable CS8618
using Newtonsoft.Json;

namespace SpotifyPrivate
{
    namespace PlaylistContent
    {
        public class AddedAt
        {
            [JsonProperty("isoString", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime? IsoString { get; set; }
        }

        public class AlbumOfTrack
        {
            [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
            public string Uri { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("artists", NullValueHandling = NullValueHandling.Ignore)]
            public Artists Artists { get; set; }

            [JsonProperty("coverArt", NullValueHandling = NullValueHandling.Ignore)]
            public CoverArt CoverArt { get; set; }
        }

        public class Artists
        {
            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items { get; set; }
        }

        public class Attribute
        {
            [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
            public string Key { get; set; }

            [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
            public string Value { get; set; }
        }

        public class Content
        {
            [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
            public string Typename { get; set; }

            [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalCount { get; set; }

            [JsonProperty("pagingInfo", NullValueHandling = NullValueHandling.Ignore)]
            public PagingInfo PagingInfo { get; set; }

            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Playlist.Item> Items { get; set; }
        }

        public class ContentRating
        {
            [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
            public string Label { get; set; }
        }

        public class CoverArt
        {
            [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
            public List<Source> Sources { get; set; }
        }

        public class Data
        {
            [JsonProperty("playlistV2", NullValueHandling = NullValueHandling.Ignore)]
            public PlaylistV2 PlaylistV2 { get; set; }

            [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
            public string Typename { get; set; }

            [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
            public string Uri { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("trackDuration", NullValueHandling = NullValueHandling.Ignore)]
            public TrackDuration TrackDuration { get; set; }

            [JsonProperty("playcount", NullValueHandling = NullValueHandling.Ignore)]
            public string Playcount { get; set; }

            [JsonProperty("albumOfTrack", NullValueHandling = NullValueHandling.Ignore)]
            public AlbumOfTrack AlbumOfTrack { get; set; }

            [JsonProperty("artists", NullValueHandling = NullValueHandling.Ignore)]
            public Artists Artists { get; set; }

            [JsonProperty("discNumber", NullValueHandling = NullValueHandling.Ignore)]
            public int? DiscNumber { get; set; }

            [JsonProperty("trackNumber", NullValueHandling = NullValueHandling.Ignore)]
            public int? TrackNumber { get; set; }

            [JsonProperty("playability", NullValueHandling = NullValueHandling.Ignore)]
            public Playability Playability { get; set; }

            [JsonProperty("contentRating", NullValueHandling = NullValueHandling.Ignore)]
            public ContentRating ContentRating { get; set; }
        }

        public class Extensions
        {
        }

        public class Item
        {
            [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
            public string Uid { get; set; }

            [JsonProperty("addedAt", NullValueHandling = NullValueHandling.Ignore)]
            public AddedAt AddedAt { get; set; }

            [JsonProperty("addedBy", NullValueHandling = NullValueHandling.Ignore)]
            public object AddedBy { get; set; }

            [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
            public List<Attribute> Attributes { get; set; }

            [JsonProperty("itemV2", NullValueHandling = NullValueHandling.Ignore)]
            public ItemV2 ItemV2 { get; set; }

            [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
            public string Uri { get; set; }

            [JsonProperty("profile", NullValueHandling = NullValueHandling.Ignore)]
            public Profile Profile { get; set; }
        }

        public class ItemV2
        {
            [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
            public string Typename { get; set; }

            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public Data Data { get; set; }
        }

        public class PagingInfo
        {
            [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
            public int? Offset { get; set; }

            [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
            public int? Limit { get; set; }
        }

        public class Playability
        {
            [JsonProperty("playable", NullValueHandling = NullValueHandling.Ignore)]
            public bool? Playable { get; set; }

            [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
            public string Reason { get; set; }
        }

        public class PlaylistV2
        {
            [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
            public string Typename { get; set; }

            [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
            public Content Content { get; set; }
        }

        public class Profile
        {
            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }
        }

        public class Base
        {
            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public Data Data { get; set; }

            [JsonProperty("extensions", NullValueHandling = NullValueHandling.Ignore)]
            public Extensions Extensions { get; set; }
        }

        public class Source
        {
            [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
            public string Url { get; set; }

            [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
            public int? Width { get; set; }

            [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
            public int? Height { get; set; }
        }

        public class TrackDuration
        {
            [JsonProperty("totalMilliseconds", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalMilliseconds { get; set; }
        }
    }
}
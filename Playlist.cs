#pragma warning disable CS8618
using Newtonsoft.Json;

namespace SpotifyPrivate
{
    namespace Playlist
    {
        public class AddedAt
        {
            [JsonProperty("isoString", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime? IsoString { get; set; }
        }

        public class AddedBy
        {
            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public Data Data { get; set; }
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

        public class Avatar
        {
            [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
            public List<Source> Sources { get; set; }
        }

        public class ColorRaw
        {
            [JsonProperty("hex", NullValueHandling = NullValueHandling.Ignore)]
            public string Hex { get; set; }

            [JsonProperty("isFallback", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsFallback { get; set; }
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
            public List<Item> Items { get; set; }
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

            [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
            public string Username { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("avatar", NullValueHandling = NullValueHandling.Ignore)]
            public Avatar Avatar { get; set; }

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

        public class ExtractedColors
        {
            [JsonProperty("colorRaw", NullValueHandling = NullValueHandling.Ignore)]
            public ColorRaw ColorRaw { get; set; }
        }

        public class Images
        {
            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items { get; set; }
        }

        public class Item
        {
            [JsonProperty("extractedColors", NullValueHandling = NullValueHandling.Ignore)]
            public ExtractedColors ExtractedColors { get; set; }

            [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
            public List<Source> Sources { get; set; }

            [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
            public string Uid { get; set; }

            [JsonProperty("addedAt", NullValueHandling = NullValueHandling.Ignore)]
            public AddedAt AddedAt { get; set; }

            [JsonProperty("addedBy", NullValueHandling = NullValueHandling.Ignore)]
            public AddedBy AddedBy { get; set; }

            [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> Attributes { get; set; }

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

        public class OwnerV2
        {
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

            [JsonProperty("revisionId", NullValueHandling = NullValueHandling.Ignore)]
            public string RevisionId { get; set; }

            [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
            public string Uri { get; set; }

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }

            [JsonProperty("ownerV2", NullValueHandling = NullValueHandling.Ignore)]
            public OwnerV2 OwnerV2 { get; set; }

            [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
            public Images Images { get; set; }

            [JsonProperty("collaborative", NullValueHandling = NullValueHandling.Ignore)]
            public bool? Collaborative { get; set; }

            [JsonProperty("followers", NullValueHandling = NullValueHandling.Ignore)]
            public int? Followers { get; set; }

            [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
            public string Format { get; set; }

            [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> Attributes { get; set; }

            [JsonProperty("sharingInfo", NullValueHandling = NullValueHandling.Ignore)]
            public SharingInfo SharingInfo { get; set; }

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

        public class SharingInfo
        {
            [JsonProperty("shareUrl", NullValueHandling = NullValueHandling.Ignore)]
            public string ShareUrl { get; set; }
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
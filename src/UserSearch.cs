#pragma warning disable CS8618
using Newtonsoft.Json;

namespace SpotifyPrivate
{
    namespace UserSearch
    {       
        public class Avatar
        {
            [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
            public List<Source> Sources { get; set; }

            [JsonProperty("extractedColors", NullValueHandling = NullValueHandling.Ignore)]
            public ExtractedColors ExtractedColors { get; set; }
        }

        public class ColorDark
        {
            [JsonProperty("hex", NullValueHandling = NullValueHandling.Ignore)]
            public string Hex { get; set; }

            [JsonProperty("isFallback", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsFallback { get; set; }
        }

        public class Data
        {
            [JsonProperty("searchV2", NullValueHandling = NullValueHandling.Ignore)]
            public SearchV2 SearchV2 { get; set; }

            [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
            public string Typename { get; set; }

            [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
            public string Uri { get; set; }

            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
            public string DisplayName { get; set; }

            [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
            public string Username { get; set; }

            [JsonProperty("avatar", NullValueHandling = NullValueHandling.Ignore)]
            public Avatar Avatar { get; set; }
        }

        public class Extensions
        {
            [JsonProperty("requestIds", NullValueHandling = NullValueHandling.Ignore)]
            public RequestIds RequestIds { get; set; }
        }

        public class ExtractedColors
        {
            [JsonProperty("colorDark", NullValueHandling = NullValueHandling.Ignore)]
            public ColorDark ColorDark { get; set; }
        }

        public class Item
        {
            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public Data Data { get; set; }
        }

        public class PagingInfo
        {
            [JsonProperty("nextOffset", NullValueHandling = NullValueHandling.Ignore)]
            public int? NextOffset { get; set; }

            [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
            public int? Limit { get; set; }
        }

        public class RequestIds
        {
            [JsonProperty("/searchV2", NullValueHandling = NullValueHandling.Ignore)]
            public SearchV2 SearchV2 { get; set; }
        }

        public class Base
        {
            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public Data Data { get; set; }

            [JsonProperty("extensions", NullValueHandling = NullValueHandling.Ignore)]
            public Extensions Extensions { get; set; }
        }

        public class SearchV2
        {
            [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
            public string Query { get; set; }

            [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
            public Users Users { get; set; }
        }

        public class SearchV22
        {
            [JsonProperty("search-api", NullValueHandling = NullValueHandling.Ignore)]
            public string SearchApi { get; set; }
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

        public class Users
        {
            [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalCount { get; set; }

            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items { get; set; }

            [JsonProperty("pagingInfo", NullValueHandling = NullValueHandling.Ignore)]
            public PagingInfo PagingInfo { get; set; }
        }


    }
}
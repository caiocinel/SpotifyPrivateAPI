#pragma warning disable CS8618
using Newtonsoft.Json;

namespace Artist
{

    public class AlbumOfTrack
    {
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        [JsonProperty("coverArt", NullValueHandling = NullValueHandling.Ignore)]
        public CoverArt CoverArt { get; set; }
    }

    public class Albums
    {
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class AppearsOn
    {
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class Artists
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class ArtistUnion
    {
        [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
        public string Typename { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        [JsonProperty("saved", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Saved { get; set; }

        [JsonProperty("sharingInfo", NullValueHandling = NullValueHandling.Ignore)]
        public SharingInfo SharingInfo { get; set; }

        [JsonProperty("preRelease", NullValueHandling = NullValueHandling.Ignore)]
        public object PreRelease { get; set; }

        [JsonProperty("profile", NullValueHandling = NullValueHandling.Ignore)]
        public Profile Profile { get; set; }

        [JsonProperty("visuals", NullValueHandling = NullValueHandling.Ignore)]
        public Visuals Visuals { get; set; }

        [JsonProperty("discography", NullValueHandling = NullValueHandling.Ignore)]
        public Discography Discography { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public Stats Stats { get; set; }

        [JsonProperty("relatedContent", NullValueHandling = NullValueHandling.Ignore)]
        public RelatedContent RelatedContent { get; set; }

        [JsonProperty("goods", NullValueHandling = NullValueHandling.Ignore)]
        public Goods Goods { get; set; }
    }

    public class AvatarImage
    {
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Source> Sources { get; set; }

        [JsonProperty("extractedColors", NullValueHandling = NullValueHandling.Ignore)]
        public ExtractedColors ExtractedColors { get; set; }
    }

    public class BackgroundImage
    {
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Source> Sources { get; set; }
    }

    public class Biography
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
    }

    public class ColorRaw
    {
        [JsonProperty("hex", NullValueHandling = NullValueHandling.Ignore)]
        public string Hex { get; set; }
    }

    public class Compilations
    {
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class Concerts
    {
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }

        [JsonProperty("pagingInfo", NullValueHandling = NullValueHandling.Ignore)]
        public PagingInfo PagingInfo { get; set; }
    }

    public class ContentRating
    {
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }
    }

    public class Coordinates
    {
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public double? Latitude { get; set; }

        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public double? Longitude { get; set; }
    }

    public class Copyright
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class CoverArt
    {
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Source> Sources { get; set; }
    }

    public class Data
    {
        [JsonProperty("artistUnion", NullValueHandling = NullValueHandling.Ignore)]
        public ArtistUnion ArtistUnion { get; set; }

        [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
        public string Typename { get; set; }

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

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
    }

    public class Date
    {
        [JsonProperty("year", NullValueHandling = NullValueHandling.Ignore)]
        public int? Year { get; set; }

        [JsonProperty("month", NullValueHandling = NullValueHandling.Ignore)]
        public int? Month { get; set; }

        [JsonProperty("day", NullValueHandling = NullValueHandling.Ignore)]
        public int? Day { get; set; }

        [JsonProperty("precision", NullValueHandling = NullValueHandling.Ignore)]
        public string Precision { get; set; }

        [JsonProperty("hour", NullValueHandling = NullValueHandling.Ignore)]
        public int? Hour { get; set; }

        [JsonProperty("minute", NullValueHandling = NullValueHandling.Ignore)]
        public int? Minute { get; set; }

        [JsonProperty("second", NullValueHandling = NullValueHandling.Ignore)]
        public int? Second { get; set; }

        [JsonProperty("isoString", NullValueHandling = NullValueHandling.Ignore)]
        public string IsoString { get; set; }
    }

    public class Discography
    {
        [JsonProperty("latest", NullValueHandling = NullValueHandling.Ignore)]
        public object Latest { get; set; }

        [JsonProperty("popularReleasesAlbums", NullValueHandling = NullValueHandling.Ignore)]
        public PopularReleasesAlbums PopularReleasesAlbums { get; set; }

        [JsonProperty("singles", NullValueHandling = NullValueHandling.Ignore)]
        public Singles Singles { get; set; }

        [JsonProperty("albums", NullValueHandling = NullValueHandling.Ignore)]
        public Albums Albums { get; set; }

        [JsonProperty("compilations", NullValueHandling = NullValueHandling.Ignore)]
        public Compilations Compilations { get; set; }

        [JsonProperty("topTracks", NullValueHandling = NullValueHandling.Ignore)]
        public TopTracks TopTracks { get; set; }
    }

    public class DiscoveredOnV2
    {
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class Duration
    {
        [JsonProperty("totalMilliseconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalMilliseconds { get; set; }
    }

    public class Events
    {
        [JsonProperty("userLocation", NullValueHandling = NullValueHandling.Ignore)]
        public UserLocation UserLocation { get; set; }

        [JsonProperty("concerts", NullValueHandling = NullValueHandling.Ignore)]
        public Concerts Concerts { get; set; }
    }

    public class Extensions
    {
    }

    public class ExternalLinks
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class ExtractedColors
    {
        [JsonProperty("colorRaw", NullValueHandling = NullValueHandling.Ignore)]
        public ColorRaw ColorRaw { get; set; }
    }

    public class FeaturingV2
    {
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class Gallery
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class Goods
    {
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public Events Events { get; set; }

        [JsonProperty("merch", NullValueHandling = NullValueHandling.Ignore)]
        public Merch Merch { get; set; }
    }

    public class HeaderImage
    {
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Source> Sources { get; set; }

        [JsonProperty("extractedColors", NullValueHandling = NullValueHandling.Ignore)]
        public ExtractedColors ExtractedColors { get; set; }
    }

    public class Image
    {
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Source> Sources { get; set; }
    }

    public class Images
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }

        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }
    }

    public class Item
    {
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public Images Images { get; set; }
    }

    public class Item10
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("copyright", NullValueHandling = NullValueHandling.Ignore)]
        public Copyright Copyright { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public Date Date { get; set; }

        [JsonProperty("coverArt", NullValueHandling = NullValueHandling.Ignore)]
        public CoverArt CoverArt { get; set; }

        [JsonProperty("tracks", NullValueHandling = NullValueHandling.Ignore)]
        public Tracks Tracks { get; set; }

        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        [JsonProperty("playability", NullValueHandling = NullValueHandling.Ignore)]
        public Playability Playability { get; set; }

        [JsonProperty("sharingInfo", NullValueHandling = NullValueHandling.Ignore)]
        public SharingInfo SharingInfo { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("releases", NullValueHandling = NullValueHandling.Ignore)]
        public Releases Releases { get; set; }

        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        [JsonProperty("track", NullValueHandling = NullValueHandling.Ignore)]
        public Track Track { get; set; }

        [JsonProperty("profile", NullValueHandling = NullValueHandling.Ignore)]
        public Profile Profile { get; set; }

        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Source> Sources { get; set; }

        [JsonProperty("numberOfListeners", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfListeners { get; set; }

        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        [JsonProperty("artists", NullValueHandling = NullValueHandling.Ignore)]
        public Artists Artists { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Data Data { get; set; }

        [JsonProperty("visuals", NullValueHandling = NullValueHandling.Ignore)]
        public Visuals Visuals { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        [JsonProperty("festival", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Festival { get; set; }

        [JsonProperty("nearUser", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NearUser { get; set; }

        [JsonProperty("venue", NullValueHandling = NullValueHandling.Ignore)]
        public Venue Venue { get; set; }

        [JsonProperty("partnerLinks", NullValueHandling = NullValueHandling.Ignore)]
        public PartnerLinks PartnerLinks { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("partnerName", NullValueHandling = NullValueHandling.Ignore)]
        public string PartnerName { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public Image Image { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public string Price { get; set; }
    }

    public class ItemV2
    {
    }

    public class Location
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    public class Merch
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class OwnerV2
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Data Data { get; set; }
    }

    public class PagingInfo
    {
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }
    }

    public class PartnerLinks
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class PinnedItem
    {
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("backgroundImage", NullValueHandling = NullValueHandling.Ignore)]
        public BackgroundImage BackgroundImage { get; set; }

        [JsonProperty("itemV2", NullValueHandling = NullValueHandling.Ignore)]
        public ItemV2 ItemV2 { get; set; }

        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public Item Item { get; set; }
    }

    public class Playability
    {
        [JsonProperty("playable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Playable { get; set; }

        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }
    }

    public class PlaylistsV2
    {
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class PopularReleasesAlbums
    {
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class Profile
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("verified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Verified { get; set; }

        [JsonProperty("pinnedItem", NullValueHandling = NullValueHandling.Ignore)]
        public PinnedItem PinnedItem { get; set; }

        [JsonProperty("biography", NullValueHandling = NullValueHandling.Ignore)]
        public Biography Biography { get; set; }

        [JsonProperty("externalLinks", NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLinks ExternalLinks { get; set; }

        [JsonProperty("playlistsV2", NullValueHandling = NullValueHandling.Ignore)]
        public PlaylistsV2 PlaylistsV2 { get; set; }
    }

    public class RelatedArtists
    {
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class RelatedContent
    {
        [JsonProperty("appearsOn", NullValueHandling = NullValueHandling.Ignore)]
        public AppearsOn AppearsOn { get; set; }

        [JsonProperty("featuringV2", NullValueHandling = NullValueHandling.Ignore)]
        public FeaturingV2 FeaturingV2 { get; set; }

        [JsonProperty("discoveredOnV2", NullValueHandling = NullValueHandling.Ignore)]
        public DiscoveredOnV2 DiscoveredOnV2 { get; set; }

        [JsonProperty("relatedArtists", NullValueHandling = NullValueHandling.Ignore)]
        public RelatedArtists RelatedArtists { get; set; }
    }

    public class Releases
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }

        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }
    }

    public class Response
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

        [JsonProperty("shareId", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareId { get; set; }
    }

    public class Singles
    {
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
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

    public class Stats
    {
        [JsonProperty("followers", NullValueHandling = NullValueHandling.Ignore)]
        public int? Followers { get; set; }

        [JsonProperty("monthlyListeners", NullValueHandling = NullValueHandling.Ignore)]
        public int? MonthlyListeners { get; set; }

        [JsonProperty("worldRank", NullValueHandling = NullValueHandling.Ignore)]
        public int? WorldRank { get; set; }

        [JsonProperty("topCities", NullValueHandling = NullValueHandling.Ignore)]
        public TopCities TopCities { get; set; }
    }

    public class TopCities
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class TopTracks
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class Track
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("playcount", NullValueHandling = NullValueHandling.Ignore)]
        public string Playcount { get; set; }

        [JsonProperty("discNumber", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiscNumber { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public Duration Duration { get; set; }

        [JsonProperty("playability", NullValueHandling = NullValueHandling.Ignore)]
        public Playability Playability { get; set; }

        [JsonProperty("contentRating", NullValueHandling = NullValueHandling.Ignore)]
        public ContentRating ContentRating { get; set; }

        [JsonProperty("artists", NullValueHandling = NullValueHandling.Ignore)]
        public Artists Artists { get; set; }

        [JsonProperty("albumOfTrack", NullValueHandling = NullValueHandling.Ignore)]
        public AlbumOfTrack AlbumOfTrack { get; set; }
    }

    public class Tracks
    {
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }
    }

    public class UserLocation
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    public class Venue
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public Location Location { get; set; }

        [JsonProperty("coordinates", NullValueHandling = NullValueHandling.Ignore)]
        public Coordinates Coordinates { get; set; }
    }

    public class Visuals
    {
        [JsonProperty("gallery", NullValueHandling = NullValueHandling.Ignore)]
        public Gallery Gallery { get; set; }

        [JsonProperty("avatarImage", NullValueHandling = NullValueHandling.Ignore)]
        public AvatarImage AvatarImage { get; set; }

        [JsonProperty("headerImage", NullValueHandling = NullValueHandling.Ignore)]
        public HeaderImage HeaderImage { get; set; }
    }

}
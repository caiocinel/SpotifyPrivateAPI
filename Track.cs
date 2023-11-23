#pragma warning disable CS8618
using Newtonsoft.Json;

namespace Track
{

    public class AlbumOfTrack
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        [JsonProperty("coverArt", NullValueHandling = NullValueHandling.Ignore)]
        public CoverArt CoverArt { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("copyright", NullValueHandling = NullValueHandling.Ignore)]
        public Copyright Copyright { get; set; }

        [JsonProperty("courtesyLine", NullValueHandling = NullValueHandling.Ignore)]
        public string CourtesyLine { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("playability", NullValueHandling = NullValueHandling.Ignore)]
        public Playability Playability { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public Date Date { get; set; }

        [JsonProperty("sharingInfo", NullValueHandling = NullValueHandling.Ignore)]
        public SharingInfo SharingInfo { get; set; }

        [JsonProperty("tracks", NullValueHandling = NullValueHandling.Ignore)]
        public Tracks Tracks { get; set; }
    }

    public class Albums
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

    public class AudioPreviews
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class AvatarImage
    {
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Source> Sources { get; set; }
    }

    public class ColorRaw
    {
        [JsonProperty("hex", NullValueHandling = NullValueHandling.Ignore)]
        public string Hex { get; set; }
    }

    public class ContentRating
    {
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }
    }

    public class Copyright
    {
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class CoverArt
    {
        [JsonProperty("extractedColors", NullValueHandling = NullValueHandling.Ignore)]
        public ExtractedColors ExtractedColors { get; set; }

        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Source> Sources { get; set; }
    }

    public class Data
    {
        [JsonProperty("trackUnion", NullValueHandling = NullValueHandling.Ignore)]
        public TrackUnion TrackUnion { get; set; }
    }

    public class Date
    {
        [JsonProperty("isoString", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? IsoString { get; set; }

        [JsonProperty("precision", NullValueHandling = NullValueHandling.Ignore)]
        public string Precision { get; set; }

        [JsonProperty("year", NullValueHandling = NullValueHandling.Ignore)]
        public int? Year { get; set; }
    }

    public class Discography
    {
        [JsonProperty("singles", NullValueHandling = NullValueHandling.Ignore)]
        public Singles Singles { get; set; }

        [JsonProperty("albums", NullValueHandling = NullValueHandling.Ignore)]
        public Albums Albums { get; set; }

        [JsonProperty("popularReleasesAlbums", NullValueHandling = NullValueHandling.Ignore)]
        public PopularReleasesAlbums PopularReleasesAlbums { get; set; }

        [JsonProperty("topTracks", NullValueHandling = NullValueHandling.Ignore)]
        public TopTracks TopTracks { get; set; }
    }

    public class Duration
    {
        [JsonProperty("totalMilliseconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalMilliseconds { get; set; }
    }

    public class Extensions
    {
    }

    public class ExtractedColors
    {
        [JsonProperty("colorRaw", NullValueHandling = NullValueHandling.Ignore)]
        public ColorRaw ColorRaw { get; set; }
    }

    public class FirstArtist
    {
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        [JsonProperty("visuals", NullValueHandling = NullValueHandling.Ignore)]
        public Visuals Visuals { get; set; }

        [JsonProperty("profile", NullValueHandling = NullValueHandling.Ignore)]
        public Profile Profile { get; set; }

        [JsonProperty("discography", NullValueHandling = NullValueHandling.Ignore)]
        public Discography Discography { get; set; }

        [JsonProperty("relatedContent", NullValueHandling = NullValueHandling.Ignore)]
        public RelatedContent RelatedContent { get; set; }

        [JsonProperty("track", NullValueHandling = NullValueHandling.Ignore)]
        public Track Track { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("releases", NullValueHandling = NullValueHandling.Ignore)]
        public Releases Releases { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("playability", NullValueHandling = NullValueHandling.Ignore)]
        public Playability Playability { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public Date Date { get; set; }

        [JsonProperty("sharingInfo", NullValueHandling = NullValueHandling.Ignore)]
        public SharingInfo SharingInfo { get; set; }

        [JsonProperty("tracks", NullValueHandling = NullValueHandling.Ignore)]
        public Tracks Tracks { get; set; }

        [JsonProperty("coverArt", NullValueHandling = NullValueHandling.Ignore)]
        public CoverArt CoverArt { get; set; }
    }

    public class OtherArtists
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Items { get; set; }
    }

    public class Playability
    {
        [JsonProperty("playable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Playable { get; set; }

        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }
    }

    public class PopularReleasesAlbums
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class Previews
    {
        [JsonProperty("audioPreviews", NullValueHandling = NullValueHandling.Ignore)]
        public AudioPreviews AudioPreviews { get; set; }
    }

    public class Profile
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
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
        [JsonProperty("relatedArtists", NullValueHandling = NullValueHandling.Ignore)]
        public RelatedArtists RelatedArtists { get; set; }
    }

    public class Releases
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
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
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public class TopTracks
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class Track
    {
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        [JsonProperty("trackNumber", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrackNumber { get; set; }

        [JsonProperty("artists", NullValueHandling = NullValueHandling.Ignore)]
        public Artists Artists { get; set; }

        [JsonProperty("albumOfTrack", NullValueHandling = NullValueHandling.Ignore)]
        public AlbumOfTrack AlbumOfTrack { get; set; }

        [JsonProperty("playability", NullValueHandling = NullValueHandling.Ignore)]
        public Playability Playability { get; set; }

        [JsonProperty("playcount", NullValueHandling = NullValueHandling.Ignore)]
        public string Playcount { get; set; }

        [JsonProperty("previews", NullValueHandling = NullValueHandling.Ignore)]
        public Previews Previews { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public Duration Duration { get; set; }

        [JsonProperty("contentRating", NullValueHandling = NullValueHandling.Ignore)]
        public ContentRating ContentRating { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
    }

    public class Tracks
    {
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class TrackUnion
    {
        [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
        public string Typename { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("contentRating", NullValueHandling = NullValueHandling.Ignore)]
        public ContentRating ContentRating { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public Duration Duration { get; set; }

        [JsonProperty("playability", NullValueHandling = NullValueHandling.Ignore)]
        public Playability Playability { get; set; }

        [JsonProperty("trackNumber", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrackNumber { get; set; }

        [JsonProperty("playcount", NullValueHandling = NullValueHandling.Ignore)]
        public string Playcount { get; set; }

        [JsonProperty("saved", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Saved { get; set; }

        [JsonProperty("sharingInfo", NullValueHandling = NullValueHandling.Ignore)]
        public SharingInfo SharingInfo { get; set; }

        [JsonProperty("firstArtist", NullValueHandling = NullValueHandling.Ignore)]
        public FirstArtist FirstArtist { get; set; }

        [JsonProperty("otherArtists", NullValueHandling = NullValueHandling.Ignore)]
        public OtherArtists OtherArtists { get; set; }

        [JsonProperty("albumOfTrack", NullValueHandling = NullValueHandling.Ignore)]
        public AlbumOfTrack AlbumOfTrack { get; set; }
    }

    public class Visuals
    {
        [JsonProperty("avatarImage", NullValueHandling = NullValueHandling.Ignore)]
        public AvatarImage AvatarImage { get; set; }
    }

}
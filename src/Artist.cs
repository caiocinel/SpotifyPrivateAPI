#pragma warning disable CS8618
using Newtonsoft.Json;

namespace SpotifyPrivate
{
    namespace Artist
    {
        public class AlbumOfTrack
        {
            [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
            public string Uri;

            [JsonProperty("coverArt", NullValueHandling = NullValueHandling.Ignore)]
            public CoverArt CoverArt;
        }

        public class Albums
        {
            [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalCount;

            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;
        }

        public class AppearsOn
        {
            [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalCount;

            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;
        }

        public class Artists
        {
            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;
        }

        public class ArtistUnion
        {
            [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
            public string Typename;

            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id;

            [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
            public string Uri;

            [JsonProperty("saved", NullValueHandling = NullValueHandling.Ignore)]
            public bool? Saved;

            [JsonProperty("sharingInfo", NullValueHandling = NullValueHandling.Ignore)]
            public SharingInfo SharingInfo;

            [JsonProperty("preRelease", NullValueHandling = NullValueHandling.Ignore)]
            public object PreRelease;

            [JsonProperty("profile", NullValueHandling = NullValueHandling.Ignore)]
            public Profile Profile;

            [JsonProperty("visuals", NullValueHandling = NullValueHandling.Ignore)]
            public Visuals Visuals;

            [JsonProperty("discography", NullValueHandling = NullValueHandling.Ignore)]
            public Discography Discography;

            [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
            public Stats Stats;

            [JsonProperty("relatedContent", NullValueHandling = NullValueHandling.Ignore)]
            public RelatedContent RelatedContent;

            [JsonProperty("goods", NullValueHandling = NullValueHandling.Ignore)]
            public Goods Goods;
        }

        public class AvatarImage
        {
            [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
            public List<Source> Sources;

            [JsonProperty("extractedColors", NullValueHandling = NullValueHandling.Ignore)]
            public ExtractedColors ExtractedColors;
        }

        public class Biography
        {
            [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
            public string Type;

            [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
            public string Text;
        }

        public class ColorRaw
        {
            [JsonProperty("hex", NullValueHandling = NullValueHandling.Ignore)]
            public string Hex;
        }

        public class Compilations
        {
            [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalCount;

            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;
        }

        public class Concerts
        {
            [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalCount;

            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> Items;

            [JsonProperty("pagingInfo", NullValueHandling = NullValueHandling.Ignore)]
            public PagingInfo PagingInfo;
        }

        public class ContentRating
        {
            [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
            public string Label;
        }

        public class Copyright
        {
            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;
        }

        public class CoverArt
        {
            [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
            public List<Source> Sources;
        }

        public class Data
        {
            [JsonProperty("artistUnion", NullValueHandling = NullValueHandling.Ignore)]
            public ArtistUnion ArtistUnion;

            [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
            public string Typename;

            [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
            public string Uri;

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name;

            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description;

            [JsonProperty("ownerV2", NullValueHandling = NullValueHandling.Ignore)]
            public OwnerV2 OwnerV2;

            [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
            public Images Images;

            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id;
        }

        public class Date
        {
            [JsonProperty("year", NullValueHandling = NullValueHandling.Ignore)]
            public int? Year;

            [JsonProperty("month", NullValueHandling = NullValueHandling.Ignore)]
            public int? Month;

            [JsonProperty("day", NullValueHandling = NullValueHandling.Ignore)]
            public int? Day;

            [JsonProperty("precision", NullValueHandling = NullValueHandling.Ignore)]
            public string Precision;
        }

        public class Discography
        {
            [JsonProperty("latest", NullValueHandling = NullValueHandling.Ignore)]
            public object Latest;

            [JsonProperty("popularReleasesAlbums", NullValueHandling = NullValueHandling.Ignore)]
            public PopularReleasesAlbums PopularReleasesAlbums;

            [JsonProperty("singles", NullValueHandling = NullValueHandling.Ignore)]
            public Singles Singles;

            [JsonProperty("albums", NullValueHandling = NullValueHandling.Ignore)]
            public Albums Albums;

            [JsonProperty("compilations", NullValueHandling = NullValueHandling.Ignore)]
            public Compilations Compilations;

            [JsonProperty("topTracks", NullValueHandling = NullValueHandling.Ignore)]
            public TopTracks TopTracks;
        }

        public class DiscoveredOnV2
        {
            [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalCount;

            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;
        }

        public class Duration
        {
            [JsonProperty("totalMilliseconds", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalMilliseconds;
        }

        public class Events
        {
            [JsonProperty("userLocation", NullValueHandling = NullValueHandling.Ignore)]
            public UserLocation UserLocation;

            [JsonProperty("concerts", NullValueHandling = NullValueHandling.Ignore)]
            public Concerts Concerts;
        }

        public class Extensions
        {
        }

        public class ExternalLinks
        {
            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;
        }

        public class ExtractedColors
        {
            [JsonProperty("colorRaw", NullValueHandling = NullValueHandling.Ignore)]
            public ColorRaw ColorRaw;
        }

        public class FeaturingV2
        {
            [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalCount;

            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;
        }

        public class Gallery
        {
            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;
        }

        public class Goods
        {
            [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
            public Events Events;

            [JsonProperty("merch", NullValueHandling = NullValueHandling.Ignore)]
            public Merch Merch;
        }

        public class HeaderImage
        {
            [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
            public List<Source> Sources;

            [JsonProperty("extractedColors", NullValueHandling = NullValueHandling.Ignore)]
            public ExtractedColors ExtractedColors;
        }

        public class Images
        {
            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;

            [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalCount;
        }

        public class Item
        {
            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name;

            [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
            public string Url;

            [JsonProperty("releases", NullValueHandling = NullValueHandling.Ignore)]
            public Releases Releases;

            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id;

            [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
            public string Uri;

            [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
            public string Type;

            [JsonProperty("copyright", NullValueHandling = NullValueHandling.Ignore)]
            public Copyright Copyright;

            [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
            public Date Date;

            [JsonProperty("coverArt", NullValueHandling = NullValueHandling.Ignore)]
            public CoverArt CoverArt;

            [JsonProperty("tracks", NullValueHandling = NullValueHandling.Ignore)]
            public Tracks Tracks;

            [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
            public string Label;

            [JsonProperty("playability", NullValueHandling = NullValueHandling.Ignore)]
            public Playability Playability;

            [JsonProperty("sharingInfo", NullValueHandling = NullValueHandling.Ignore)]
            public SharingInfo SharingInfo;

            [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
            public string Text;

            [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
            public string Uid;

            [JsonProperty("track", NullValueHandling = NullValueHandling.Ignore)]
            public Track Track;

            [JsonProperty("profile", NullValueHandling = NullValueHandling.Ignore)]
            public Profile Profile;

            [JsonProperty("numberOfListeners", NullValueHandling = NullValueHandling.Ignore)]
            public int? NumberOfListeners;

            [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
            public string City;

            [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
            public string Country;

            [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
            public string Region;

            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public Data Data;

            [JsonProperty("artists", NullValueHandling = NullValueHandling.Ignore)]
            public Artists Artists;

            [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
            public List<Source> Sources;

            [JsonProperty("visuals", NullValueHandling = NullValueHandling.Ignore)]
            public Visuals Visuals;
        }

        public class Merch
        {
            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> Items;
        }

        public class OwnerV2
        {
            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public Data Data;
        }

        public class PagingInfo
        {
            [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
            public int? Limit;
        }

        public class Playability
        {
            [JsonProperty("playable", NullValueHandling = NullValueHandling.Ignore)]
            public bool? Playable;

            [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
            public string Reason;
        }

        public class PlaylistsV2
        {
            [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalCount;

            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;
        }

        public class PopularReleasesAlbums
        {
            [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalCount;

            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;
        }

        public class Profile
        {
            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name;

            [JsonProperty("verified", NullValueHandling = NullValueHandling.Ignore)]
            public bool? Verified;

            [JsonProperty("pinnedItem", NullValueHandling = NullValueHandling.Ignore)]
            public object PinnedItem;

            [JsonProperty("biography", NullValueHandling = NullValueHandling.Ignore)]
            public Biography Biography;

            [JsonProperty("externalLinks", NullValueHandling = NullValueHandling.Ignore)]
            public ExternalLinks ExternalLinks;

            [JsonProperty("playlistsV2", NullValueHandling = NullValueHandling.Ignore)]
            public PlaylistsV2 PlaylistsV2;
        }

        public class RelatedArtists
        {
            [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalCount;

            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;
        }

        public class RelatedContent
        {
            [JsonProperty("appearsOn", NullValueHandling = NullValueHandling.Ignore)]
            public AppearsOn AppearsOn;

            [JsonProperty("featuringV2", NullValueHandling = NullValueHandling.Ignore)]
            public FeaturingV2 FeaturingV2;

            [JsonProperty("discoveredOnV2", NullValueHandling = NullValueHandling.Ignore)]
            public DiscoveredOnV2 DiscoveredOnV2;

            [JsonProperty("relatedArtists", NullValueHandling = NullValueHandling.Ignore)]
            public RelatedArtists RelatedArtists;
        }

        public class Releases
        {
            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;

            [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalCount;
        }

        public class Base
        {
            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public Data Data;

            [JsonProperty("extensions", NullValueHandling = NullValueHandling.Ignore)]
            public Extensions Extensions;
        }

        public class SharingInfo
        {
            [JsonProperty("shareUrl", NullValueHandling = NullValueHandling.Ignore)]
            public string ShareUrl;

            [JsonProperty("shareId", NullValueHandling = NullValueHandling.Ignore)]
            public string ShareId;
        }

        public class Singles
        {
            [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalCount;

            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;
        }

        public class Source
        {
            [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
            public string Url;

            [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
            public object Width;

            [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
            public object Height;
        }

        public class Stats
        {
            [JsonProperty("followers", NullValueHandling = NullValueHandling.Ignore)]
            public int? Followers;

            [JsonProperty("monthlyListeners", NullValueHandling = NullValueHandling.Ignore)]
            public int? MonthlyListeners;

            [JsonProperty("worldRank", NullValueHandling = NullValueHandling.Ignore)]
            public int? WorldRank;

            [JsonProperty("topCities", NullValueHandling = NullValueHandling.Ignore)]
            public TopCities TopCities;
        }

        public class TopCities
        {
            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;
        }

        public class TopTracks
        {
            [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
            public List<Item> Items;
        }

        public class Track
        {
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id;

            [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
            public string Uri;

            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name;

            [JsonProperty("playcount", NullValueHandling = NullValueHandling.Ignore)]
            public string Playcount;

            [JsonProperty("discNumber", NullValueHandling = NullValueHandling.Ignore)]
            public int? DiscNumber;

            [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
            public Duration Duration;

            [JsonProperty("playability", NullValueHandling = NullValueHandling.Ignore)]
            public Playability Playability;

            [JsonProperty("contentRating", NullValueHandling = NullValueHandling.Ignore)]
            public ContentRating ContentRating;

            [JsonProperty("artists", NullValueHandling = NullValueHandling.Ignore)]
            public Artists Artists;

            [JsonProperty("albumOfTrack", NullValueHandling = NullValueHandling.Ignore)]
            public AlbumOfTrack AlbumOfTrack;
        }

        public class Tracks
        {
            [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
            public int? TotalCount;
        }

        public class UserLocation
        {
            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name;
        }

        public class Visuals
        {
            [JsonProperty("gallery", NullValueHandling = NullValueHandling.Ignore)]
            public Gallery Gallery;

            [JsonProperty("avatarImage", NullValueHandling = NullValueHandling.Ignore)]
            public AvatarImage AvatarImage;

            [JsonProperty("headerImage", NullValueHandling = NullValueHandling.Ignore)]
            public HeaderImage HeaderImage;
        }
    }
}
using System;
using SpotifyAPI.Web;

class Program
{
    static async Task Main()
    {
        var spotify = new SpotifyPrivate.API();

        Track.Response track = await spotify.GetTrackInfo("1Yb6KzrUAyoIR103gsuV3y");
        Artist.Response artist = await spotify.GetArtistInfo(track.Data.TrackUnion.FirstArtist.Items[0].Id);

        Console.WriteLine(track.Data.TrackUnion.Name);
        Console.WriteLine(artist.Data.ArtistUnion.Profile.Name);
        Console.WriteLine(artist.Data.ArtistUnion.Stats.MonthlyListeners);
    }
}
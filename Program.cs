using System;
using System.Diagnostics;
using SpotifyAPI.Web;

class Program
{
    static async Task Main()
    {

        var spotify = new SpotifyPrivate.API();
        SpotifyPrivate.Track.Base track = await spotify.GetTrack("3rUGC1vUpkDG9CZFHMur1t");

        SpotifyPrivate.Artist.Base artist = await spotify.GetArtist("1oSgjdbgLYULVmEBojPRw8");

        Console.WriteLine(track.Data.TrackUnion.Name);
        Console.WriteLine(artist.Data.ArtistUnion.Profile.Name);

        Console.ReadKey();
    }
}
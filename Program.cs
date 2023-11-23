using System;
using System.Diagnostics;
using SpotifyAPI.Web;

class Program
{
    static async Task Main()
    {   

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        var spotify = new SpotifyPrivate.API();
        //SpotifyPrivate.Track.Base? track = await spotify.GetTrack("3rUGC1vUpkDG9CZFHMur1t");
        //SpotifyPrivate.Artist.Base? artist = await spotify.GetArtist("1oSgjdbgLYULVmEBojPRw8");
        SpotifyPrivate.Playlist.Base? playlist = await spotify.GetPlaylist("5aYJRtg9pM6eQZIRR1jSGf", fetchAllSongs: true);
        //SpotifyPrivate.User.Base? user = await spotify.GetUser("22keufaf2l4fpmztovnu5llmq");
        //SpotifyPrivate.Album.Base? album = await spotify.GetAlbum("3pQuAFj4vMjHbLlBzectUV");

        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds);

        Console.ReadKey();
    }
}
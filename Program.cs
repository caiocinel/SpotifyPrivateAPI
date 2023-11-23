using System.Net;

class Program
{
    static async Task Main()
    {   
        WebProxy proxy = new() { 
            Address = new Uri("http://username:password@127.0.0.1:25565"),
            Credentials = new NetworkCredential("username", "password")
        };


        //Proxy is optional
        var spotify = new SpotifyPrivate.API(proxyConfig: proxy);
        SpotifyPrivate.Track.Base? track = await spotify.GetTrack("3rUGC1vUpkDG9CZFHMur1t");
        SpotifyPrivate.Artist.Base? artist = await spotify.GetArtist("1oSgjdbgLYULVmEBojPRw8");
        SpotifyPrivate.Playlist.Base? playlist = await spotify.GetPlaylist("5aYJRtg9pM6eQZIRR1jSGf", fetchAllSongs: true);
        SpotifyPrivate.User.Base? user = await spotify.GetUser("22keufaf2l4fpmztovnu5llmq");
        SpotifyPrivate.Album.Base? album = await spotify.GetAlbum("3pQuAFj4vMjHbLlBzectUV");

        Console.ReadKey();
    }
}
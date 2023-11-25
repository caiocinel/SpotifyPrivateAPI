using System.Net;

class Program
{
    static async Task Main()
    {   
        WebProxy proxy = new() { 
            Address = new Uri("http://username:password@127.0.0.1:25565"),
            Credentials = new NetworkCredential("username", "password")
        };

        var spotify = new SpotifyPrivate.API();

        //If you want to use a proxy, pass it as a parameter to the constructor
        //var spotify = new SpotifyPrivate.API(new SpotifyPrivate.API(proxyConfig: proxy);

        var track = await spotify.GetTrack("3PavsmA9S6QA5lNmmsuOif");

        if (track == null)
        {
            Console.WriteLine("Track not found");
            return;
        }

        Console.WriteLine("Track Info:");
        Console.WriteLine("Name: " + track.Data.TrackUnion.Name);
        Console.WriteLine("Artist: " + track.Data.TrackUnion.FirstArtist.Items[0].Profile.Name);
        Console.WriteLine("Album: " + track.Data.TrackUnion.AlbumOfTrack.Name);
        Console.WriteLine("Playcount:" + track.Data.TrackUnion.Playcount);

        Console.WriteLine("--------------------------------------------------");

        var artist = await spotify.GetArtist("0NGAZxHanS9e0iNHpR8f2W");

        if(artist == null)
        {
            Console.WriteLine("Artist not found");
            return;
        }
        Console.WriteLine("Artist Info:");
        Console.WriteLine("Name: " + artist.Data.ArtistUnion.Profile.Name);
        Console.WriteLine("Followers: " + artist.Data.ArtistUnion.Stats.Followers);
        Console.WriteLine("Monthly Listeners: " + artist.Data.ArtistUnion.Stats.MonthlyListeners);
        Console.WriteLine("World Rank: " + artist.Data.ArtistUnion.Stats.WorldRank); // Only for Top500

        Console.WriteLine("--------------------------------------------------");

        var playlist = await spotify.GetPlaylist("37i9dQZF1DX0FOF1IUWK1W", fetchAllSongs: false); // By default only 400 first songs are fetched

        if (playlist == null)
        {
            Console.WriteLine("Playlist not found");
            return;
        }

        Console.WriteLine("Playlist Info:");
        Console.WriteLine("Name: " + playlist.Data.PlaylistV2.Name);
        Console.WriteLine("Description: " + playlist.Data.PlaylistV2.Description);
        Console.WriteLine("Likes: " + playlist.Data.PlaylistV2.Followers); // Spotify renamed "Followers" to "Likes" ¯\_(ツ)_/¯
        Console.WriteLine("Song Count: " + playlist.Data.PlaylistV2.Content.TotalCount);
        Console.WriteLine("Owner: " + playlist.Data.PlaylistV2.OwnerV2.Data.Name);

        Console.WriteLine("--------------------------------------------------");

        var user = await spotify.GetUser("22keufaf2l4fpmztovnu5llmq");

        if (user == null)
        {
            Console.WriteLine("User not found");
            return;
        }

        Console.WriteLine("User Info:");
        Console.WriteLine("Name: " + user.Name);
        Console.WriteLine("Followers: " + user.FollowersCount);
        Console.WriteLine("Following: " + user.FollowingCount);
        Console.WriteLine("Playlist Count: " + user.PublicPlaylists.Count);
        Console.WriteLine("Last Artist Played: " + user.RecentlyPlayedArtists[0].Name);

        Console.WriteLine("--------------------------------------------------");

        var album = await spotify.GetAlbum("0BNTXZBnKPTe3xUDwosPfV");

        if (album == null)
        {
            Console.WriteLine("Album not found");
            return;
        }

        Console.WriteLine("Album Info:");
        Console.WriteLine("Name: " + album.Data.AlbumUnion.Name);
        Console.WriteLine("Artist: " + album.Data.AlbumUnion.Artists.Items[0].Profile.Name);
        Console.WriteLine("Release Date: " + album.Data.AlbumUnion.Date.IsoString);
        Console.WriteLine("Total Play Count: " + album.Data.AlbumUnion.TotalPlayCount);

        Console.WriteLine("--------------------------------------------------");

        var dailyChart = await spotify.GetPlaylist("37i9dQZEVXbMXbN3EUUhlg");

        if (dailyChart == null)
        {
            Console.WriteLine("Chart not found");
            return;
        }

        Console.WriteLine("Playlist Info:");
        Console.WriteLine("Name: " + dailyChart.Data.PlaylistV2.Name);
        Console.WriteLine("Top 1 Track: " + dailyChart.Data.PlaylistV2.Content.Items[0].ItemV2.Data.Name);
        Console.WriteLine("Daily Play Count: " + dailyChart.Data.PlaylistV2.Content.Items[0].Attributes[3].Value);

        Console.WriteLine("--------------------------------------------------");

        var weeklyChart = await spotify.GetPlaylist("37i9dQZEVXbKzoK95AbRy9");

        if (weeklyChart == null)
        {
            Console.WriteLine("Chart not found");
            return;
        }

        Console.WriteLine("Playlist Info:");
        Console.WriteLine("Name: " + weeklyChart.Data.PlaylistV2.Name);
        Console.WriteLine("Top 1 Track: " + weeklyChart.Data.PlaylistV2.Content.Items[0].ItemV2.Data.Name);
        Console.WriteLine("Weekly Play Count: " + weeklyChart.Data.PlaylistV2.Content.Items[0].Attributes[3].Value);

        Console.WriteLine("--------------------------------------------------");

        var userSearch = await spotify.SearchUser("Spotify");

        if (weeklyChart == null)
        {
            Console.WriteLine("User search failed");
            return;
        }

        Console.WriteLine("Users found:");

        string usersConc = null;

        foreach (var sUser in userSearch.Data.SearchV2.Users.Items)
            usersConc = usersConc + "," + sUser.Data.Username;

        Console.WriteLine(usersConc);

        Console.WriteLine("--------------------------------------------------");



        // To use this method you need pass a valid authenticated access token to constructor
        // var spotify = new SpotifyPrivate.API(YOUR_ACCESS_TOKEN_HERE);
        var followResult = await spotify.FollowUser("22keufaf2l4fpmztovnu5llmq");
        Console.WriteLine(followResult ? "Follow Success" : "Follow Failed");


        Console.ReadKey();
    }
}
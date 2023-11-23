using System;
using SpotifyAPI.Web;

class Program
{
    static async Task Main()
    {
        //var spotify = new SpotifyClient("BQDtlBOKtytxJy_0CRhF4ERNVohe-1qv_TF-_8Q5q5mSBpmYycwdIFKip2pZtI1F3NAzvxUxTDKNdywbJInkthiDjOFydYbutF8vP0npahy42YZaGoo");

        var spotify = new SpotifyPrivateAPI();

        
        Console.WriteLine(await spotify.GetTrackInfo("59O0Xlgmh1no1j1PcdDfif"));
    }
}

//https://api-partner.spotify.com/pathfinder/v1/query?operationName=getAlbum&variables=%7B%22uri%22%3A%22spotify%3Aalbum%3A4gTpoHQozYg3jI7KTbFsfx%22%2C%22locale%22%3A%22intl-pt%22%2C%22offset%22%3A0%2C%22limit%22%3A50%7D&extensions=%7B%22persistedQuery%22%3A%7B%22version%22%3A1%2C%22sha256Hash%22%3A%2246ae954ef2d2fe7732b4b2b4022157b2e18b7ea84f70591ceb164e4de1b5d5d3%22%7D%7D
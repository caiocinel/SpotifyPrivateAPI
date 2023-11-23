# SpotifyPrivateAPI
Simple Wrapper for Front-end Private Spotify API, allowing you to get play counts and monthly listeners

## Usage

```c#

var spotify = new SpotifyPrivate.API();

var track = await spotify.GetTrack("4zZ2rPOa8itw3VuusVSicv");
Console.WriteLine(track.Data.TrackUnion.Playcount); // => 65052099
//A lot of another infos are available, check `Track.cs` for all fields

var artist = await spotify.GetArtist("0jOs0wnXCu1bGGP7kh5uIu");
Console.WriteLine(artist.Data.ArtistUnion.Stats.MonthlyListeners); // => 2825621
//A lot of another infos like Followers are available, check `Artist.cs` for all fields


//See Program.cs for use more example
```


## How it works

Routes are based on [Spotify Web Player](https://open.spotify.com/) API, all requests use anynomous token to get informations

## Available methods

- Track
- Artist
- Playlist (with recursive content fetch and chart data support)
- Album
- User

## Disclaimer

The routes used in this project were not designed to be accessed by third parties, their use is not recommended, this is more like a reverse engineering proof of concept. You are fully responsible for what you do using the data in this repository.
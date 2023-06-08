using System;

public class Playlist
{
    public string PlaylistId { get; set; }  
    public string PlaylistName { get; set; }   

    public Playlist()
    {
        createPlaylist();
    }

    public void getPlaylist()
    {
        Playlist playlist = new Playlist();
    }

    public void setPlaylist(Playlist playlist)
    {
        null;
    }

    public string createPlaylist()
    {
        Console.WriteLine("Give a name to your playlist");
        string playlistName = Console.ReadLine();

        List<Playlist> playlistName = new List<Playlist>();

        Console.WriteLine("What artsist do you like to add songs from?");
        string ArtistName = Console.ReadLine();

    }

    public string addSong()
    {

    }
}
// hier alle nummers en albums van artiesten opslaan
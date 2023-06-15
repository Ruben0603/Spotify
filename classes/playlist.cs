using System;

public class Playlist
{
    public string Name { get; set; }
    public User Owner { get; set; }
    public List<object> Songs { get; set; }

    public Playlist()
    {
    }                         

    public void getPlaylist()
    {
        Playlist playlist = new Playlist();
    }

    public void setPlaylist(Playlist playlist)
    {
        null;
    }

    //public string addSong()
    //{

    //}
}
// hier alle nummers en albums van artiesten opslaan
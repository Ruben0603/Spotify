public class Playlist
{
    public string name { get; set; }
    public User user { get; set; }
    public List<Song> songs { get; set; }
    public Playlist(string _name, User user)
    {
        this.name = _name;
        this.user = user;
        this.songs = new List<Song>();
    }

    public string getPlaylist()  // Funtion to return the playlist name 
    {
        return name;
    }

    public void AddSongs(Song song)  // Funtion to add the song
    {
        songs.Add(song);
    }
}

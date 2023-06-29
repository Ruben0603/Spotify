public class Artist
{
    public int id { get; set; }
    public string name { get; set; }
    public string song { get; set; }
    public string album { get; set; }

    public Artist(int id, string _name, string _song, string _album)
    {
        this.id = id;
        this.name = _name;
        this.song = _song;
        this.album = _album;
    }

    public string getArtist()  // Funtion to return the artist name
    {
        return name;
    }

    public string ShowSongs()  // Funtion to return the	songs
    {
        return song;
    }
    public string ShowAlbums()	// Funtion to return the albums
    {
        return album;
    }

}

﻿public class User
{
    public int id { get; set; }
    public string name { get; set; }
    public List<Playlist> playlists { get; set; }
    public User(int _id, string _name)
    {
        this.id = _id;
        this.name = _name;
        this.playlists = new List<Playlist>();
    }

    public string getUser() // Funtion to return the username
    {
        return name;
    }

    public void AddPlaylist(Playlist playlist)  // Function to add a playlist
    {
        playlists.Add(playlist);
    }
}

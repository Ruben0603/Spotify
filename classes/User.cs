using System;

class User
{
    public string Username { get; set; }
    public List<Playlist> Playlists { get; set; }
    public List<User> Friends { get; set; }

    public User()
    {
	}
}

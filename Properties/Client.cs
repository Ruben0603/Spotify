public class Client
{
    public User CurrentUser { get; set; }

    public Client(User user)
    {
        CurrentUser = user;
    }

    public void CreatePlaylist(string name) // Functie om een playlist aan te maken, Parameters geef de naam mee hoe je hem wilt noemen
    {
        CurrentUser.AddPlaylist(name); // Functie wordt terug geroepen uit de User.cs
        Console.WriteLine("Playlist created: " + name); // Laat zien welke playlist er gemaakt is
    }

    public void AddSongToPlaylist(string song, Playlist playlist) // Functie waar je Songs kan toevoegen aan een playlist, Parameters meegeven welk nummer en welke playlist
    {
        CurrentUser.AddSongToPlaylist(song, playlist); // Functie wordt terug geroepen uit de User.cs
        Console.WriteLine("Song added to playlist: " + song); // Laat zien welke songs er zijn toegevoegd aan de playlist
    }

    public void RemoveSongFromPlaylist(string song, Playlist playlist) // Function die je songs uit een playlist laat verwijderen, Parameters zijn welk nummer en welke playlist
    {
        playlist.RemoveSong(song); // Functie wordt terug geroepen uit de User.cs
        Console.WriteLine("Song removed from playlist: " + song); // Laat zien welk nummer van de playlist is verwijderd
    }

    public void PlayPlaylist(Playlist playlist) // Function die je ergens anders aanroep en waar je de parameter met de naam van de playlist meegeeft
    {
        playlist.Play(); // Speelt de afspeellijst af
    }
}
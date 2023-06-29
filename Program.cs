namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> songlist = new List<Song>();     // Creates a list Songs
            songlist.Add(new Song(1, "FLUTE", "MONSS", "rap", "3:17"));   // adds a song with an id, title, artist, genre and a duration
            songlist.Add(new Song(2, "HOPE", "NF", "rap", "4:24"));  // adds a song with an id, title, artist, genre and a duration

            Song song = new Song(0, "", "", "", "");  // adds a empty object so the list will start with id 1


            List<Album> albumlist = new List<Album>();   // Creates a list Albums
            albumlist.Add(new Album(1, "MONSS", "FLUTE"));  // adds a id, artist and a album
            albumlist.Add(new Album(2, "NF", "HOPE")); // adds a id, artist and a album

            Album album = new Album(0, "", "");  // adds a empty object so the list will start with id 1

            Artist artist = new Artist(0, "", "", ""); // adds a empty object so the list will start with id 1

            List<Artist> artistlist = new List<Artist>();  // Creates a list Artists
            artistlist.Add(new Artist(1, "MONSS", "FLUTE", "22"));  // adds artist with an id, name and albums
            artistlist.Add(new Artist(2, "NF", "HOPE", "Perception"));  // adds artist with an id, name and albums

            List<User> users = new List<User>(); // Creates a list Users
            List<Playlist> playlists = new List<Playlist>(); // Creates a list Playlist

            User user = new User(0, ""); // Creates a object user
            Playlist playlist = new Playlist("Playlist", user);  // Creates a playlist for a user 

            while (true)
            {   // A option menu
                Console.WriteLine("1: Do you want to create a playlist?");
                Console.WriteLine("2: Do you want to select a playlist?");
                Console.WriteLine("3: Do you want to play a song?");
                Console.WriteLine("4: Do you want to listen to an album?");
                Console.WriteLine("5: Do you want to listen to an artist?");
                Console.WriteLine("6: Do you want to select a user?");
                int option = Convert.ToInt32(Console.ReadLine()); // Converts the string option to an int 
                switch (option)
                {
                    case 1:  // Option 1, Create playlists

                        Playlist playlist1 = new Playlist("Drum and Base", user); // Creates the playlist Drum and Base
                        playlist1.AddSongs(new Song(1, "FLUTE", "MONSS", "rap", "3:17")); // adds a song with an id, name, artist, genre and duration
                        playlist1.AddSongs(new Song(2, "HOPE", "NF", "rap", "4:24"));  // adds a song with an id, name, artist, genre and duration
                        Playlist playlist2 = new Playlist("Hardstyle", user); // Creates the playlist Hardstyle
                        playlist2.AddSongs(new Song(1, "Made of Stars", "Refuzion", "hardstyle", "3:13")); // adds a song with an id, name, artist, genre and duration
                        playlist2.AddSongs(new Song(2, "Piece of Me", "Da Tweekaz, Refuzion", "hardstyle", "3:54")); // adds a song with an id, name, artist, genre and duration

                        playlists.Add(playlist1); // adds the playlist to a playlists list
                        playlists.Add(playlist2); // adds the playlist to a playlists list

                        Console.WriteLine("Playlists created");

                        break;

                    case 2:  // Option 2, Select playlists

                        Console.WriteLine("What playlist do you want to listen to?");
                        int p = 0;

                        foreach (Playlist _playlist in playlists)  // Returns playlists
                        {
                            Console.Write(p + " - ");
                            Console.WriteLine(_playlist.name);
                            p++;
                        }

                        Console.WriteLine("playlist " + playlists.ElementAt(int.Parse(Console.ReadLine())).name + " is playing");
                        song.ShuffleNextPause();  // Calls the function ShuffleNextPause

                        break;

                    case 3:  // Option 3, Play a song

                        Console.WriteLine("What song do you want to listen to?");
                        int s = 0;

                        foreach (Song _song in songlist)  // Returns songs
                        {
                            Console.Write(s + " - ");
                            Console.WriteLine(_song.title);
                            s++;
                        }

                        Console.WriteLine("Song " + songlist.ElementAt(int.Parse(Console.ReadLine())).title + " is playing");
                        song.ShuffleNextPause();  // Calls the function ShuffleNextPause

                        break;

                    case 4:  // Option 4, Listen to a album

                        Console.WriteLine("What album do you want to listen to?");
                        int a = 0;

                        foreach (Album _album in albumlist) // Returns albums
                        {
                            Console.Write(a + " - ");
                            Console.WriteLine(_album.title);
                            a++;
                        }

                        Console.WriteLine("Album " + albumlist.ElementAt(int.Parse(Console.ReadLine())).title + " is playing");
                        song.ShuffleNextPause();  // Calls the function ShuffleNextPause

                        break;

                    case 5:  // Option 5, Listen to an artist

                        Console.WriteLine("What artist do you want to listen to?");
                        int i = 0;

                        foreach (Artist _artist in artistlist)  // Returns artists
                        {
                            Console.Write(i + " - ");
                            Console.WriteLine(_artist.name);
                            i++;
                        }

                        Console.WriteLine("Artist " + artistlist.ElementAt(int.Parse(Console.ReadLine())).name + " playing");
                        song.ShuffleNextPause();  // Calls the function ShuffleNextPause

                        break;

                    case 6:  // Option 6, Select user

                        Console.WriteLine("Select an user");
                        i = 0;

                        foreach (User _user in users)  // Returns users
                        {
                            Console.Write(i + " - ");
                            Console.WriteLine(_user.name);
                            i++;
                        }

                        User user1 = new User(1, "Ruben"); // Creates a user

                        Playlist playlist4 = new Playlist("Drum and Base", user1); // Creates a playlist Drum and Base
                        Playlist playlist5 = new Playlist("Hardstyle", user1); // Creates a playlist Hardstyle

                        user1.AddPlaylist(playlist4); // adds the playlist to the user
                        user1.AddPlaylist(playlist5); // adds the playlist to the user

                        User user2 = new User(2, "Erik"); // Creates a user

                        Playlist playlist6 = new Playlist("Rock", user2); // Creates a playlist Rock
                        Playlist playlist7 = new Playlist("classical", user2); // Creates a playlist Classical

                        user1.AddPlaylist(playlist6); // adds the playlist to the user
                        user1.AddPlaylist(playlist7); // adds the playlist to the user

                        playlists.Add(playlist4); // adds the playlist to the playlists list
                        playlists.Add(playlist5); // adds the playlist to the playlists list

                        playlists.Add(playlist6); // adds the playlist to the playlists list
                        playlists.Add(playlist7); // adds the playlist to the playlists list

                        users.Add(user1); // adds the user to the users list
                        users.Add(user2); // adds the user to the users list

                        int u = 0;

                        foreach (User _user in users)
                        {
                            Console.Write(u + " - ");
                            Console.WriteLine(_user.name);
                            u++;
                        }

                        Console.WriteLine("User " + users.ElementAt(int.Parse(Console.ReadLine())).name + " selected. This are his/her playlists");
                        int _p = 0;

                        foreach (Playlist _playlist in users.ElementAt(0).playlists)
                        {
                            Console.Write(_p + " - ");
                            Console.WriteLine(_playlist.name);
                            _p++;
                        }

                        Console.WriteLine("Add user? 1 = yes, 0 = no");
                        Console.WriteLine("User " + users.ElementAt(int.Parse(Console.ReadLine())).name + " added");

                        break;
                }
            }
        }
    }
}
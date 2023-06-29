public class Song
{
    public int id { get; set; }
    public string title { get; set; }
    public string artist { get; set; }
    public string genre { get; set; }
    public string duration { get; set; }

    public Song(int _id, string _title, string _artist, string _genre, string _duration)
    {
        this.id = _id;
        this.title = _title;
        this.artist = _artist;
        this.genre = _genre;
        this.duration = _duration;
    }

    public string getSong()  // Funtion to return the title
    {
        return title;
    }

    public void ShuffleNextPause()  // Option menu for the functions
    {
        Console.WriteLine("1: Pause");
        Console.WriteLine("2: Next");
        Console.WriteLine("3: Shuffle");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:

                Pause(); // Calls the funtion Pause

                break;

            case 2:

                Next(); // Calls the funtion Next

                break;

            case 3:

                Shuffle();  // Calls the funtion Shuffle

                break;
        }
    }

    public void Pause()  // Pauses song
    {
        Console.WriteLine("Song paused");
    }

    public void Next() // Plays next song
    {
        Console.WriteLine("Next song " + title + " is playing");
    }

    public void Shuffle() // Makes the songs shuffle the order
    {
        Random random = new Random();

        for (int j = 0; j < 1; j++)
        {
            Console.WriteLine("Shuffle mode on");
        }
    }
}
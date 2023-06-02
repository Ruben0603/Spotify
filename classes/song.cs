using System;
using System.IO.Pipes;

public class Song
{
    private string song;
    private string title;
    private string artist;
    private string genre;

    public Song()
    {

        Artist artist = new Artist();


    }

    public void getSong(string song)
    {
        this.song = song;
    }
    public void PlayPause(string title)
    {
        Console.WriteLine("The song " + title + " by " + artist + " is playing");
        Thread.Sleep(1000);

        bool y = true;
        bool n = false;

        Console.WriteLine("Play this song(y/n)?");
        Console.ReadLine();
        if (y)
        {
            Console.WriteLine("Song is playing");
        }
        if (n)
        {
            Console.WriteLine("Song is paused");
        }
    }

    public void Shuffle()
    {
        Console.WriteLine("Do you want to shuffle?(y/n)");
        bool y = true;
        bool n = false;
        if (y)
        {
            Random random = new Random();
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(random.Next());
                Console.WriteLine("Shuffle mode on");
            }
        }
        if (n)
        {
            Console.WriteLine("Shuffle mode off");
        }
    }
}
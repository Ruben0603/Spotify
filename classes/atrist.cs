using System;

public class Artist
{
    public string Title { get; set; }
    public List<string> Artists { get; set; }
    public List<Song> Songs { get; set; }


    public Artist()
    {


    }
    public void getArtist()
    {
        return artistName;
    }

    public void setArtist(Artist artist)
    {
        this.artistName = artistName;
    }

    public void artistLists(string artistID,string artistName)
    {
        List<Album> NF = new List<Album>();
        NF.Add(artistID = 1);
        NF.Add(artistName = "NF");
        NF.Add("HOPE");
        NF.Add("The Search");

        List<Album> Eminem = new List<Album>();
        Eminem.Add(artistID = 2);
        Eminem.Add(artistName = "Eminem");
        Eminem.Add("When I'm Gone");
        Eminem.Add("Curtain Call");

        List<Album> JackHarlow = new List<Album>();
        JackHarlow.Add(artistID = 3);
        JackHarlow.Add(artistName = "Jack Harlow");
        JackHarlow.Add("Jackman");
        JackHarlow.Add("Come Home The Kids Miss You");


    }  
}

// hier alle artiesten hun albums met songs aanroepen
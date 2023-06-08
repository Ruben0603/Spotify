using System;

public class Artist
{

    public string artistID { get; set; }
    public string artistName { get; set; }
    public Artist()
    {


    }
    public void getArtist()
    {
        return artistID;
    }

    public void setArtist(Artist artist)
    {
        artist = artistName;
    }

    public void artistLists(string artistID,string artistName)
    {
        List<Artist> NF = new List<Artist>();
        NF.Add(artistID = 1);
        NF.Add(artistName = "NF");
        NF.Add("HOPE");
        NF.Add("The Search");

        List<Artist> Eminem = new List<Artist>();
        Eminem.Add(artistID = 2);
        Eminem.Add(artistName = "Eminem");
        Eminem.Add("When I'm Gone");
        Eminem.Add("Curtain Call");

        List<Artist> JackHarlow = new List<Artist>();
        JackHarlow.Add(artistID = 3);
        JackHarlow.Add(artistName = "Jack Harlow");
        JackHarlow.Add("Jackman");
        JackHarlow.Add("Come Home The Kids Miss You");
    }  
}

// hier alle artiesten hun albums met songs aanroepen
using System;

public class Album
{

	public int Id { get; set; } 
	public string Name { get; set; }
    public string Song { get; set; }

    public Album()
	{
        List<Album> HOPE = new List<Album>();
        HOPE.Add("HOPE");
        HOPE.Add("MOTTO");
        HOPE.Add("CAREFULL");

        List<Album> Eminem = new List<Album>();
        Eminem.Add("Mockingbird");
        Eminem.Add("Cleaning out my closet");
        Eminem.Add("Lose Yourself");
    }
}
// hier alle albums van artiesten met songs erin
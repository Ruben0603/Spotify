﻿namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Do you want to create a playlist?");
            Console.WriteLine("2: Do you want to select a playlist?");
            Console.WriteLine("3: Do you want to select a song?");
            int option = Convert.ToInt32(Console.ReadLine());
            
            switch(option)
            {
                case  1:

                    Playlist playlist = playlist.createPlaylist();
                    break;


                case 2:


                    break;


                case 3:

                    break;

            }
        }
    } 
}

//string[] title = { "Blinding Lights", "Nail Tech", "Wet Dreamz", "Forbidden Voices", "Programs", "Mockingbird", "MOTTO", "I" };
//string[] artist = { "The Weekend", "Jack Harlow", "J. Cole", "Martin Garrix", "Mac Miller", "Eminem", "NF", "Kendrick Lamar" };
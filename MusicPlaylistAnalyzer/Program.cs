using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusicPlaylistAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string report = null; 
            if (args.Length != 2)
            {
                Console.WriteLine("MusicPlaylistAnalyzer filepath1 filepath2");
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("all information is present");
            }

            string MusicDatafilepath = args[0];
            string Reportfilepath = args[1];

            List<Songs> songs = new List<Songs>();
            //Songs[] songs = place.ToArray();
            //List<Songs> Song = new List<Songs>();
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(MusicDatafilepath);
                reader.ReadLine();

                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\t');
                    if(values.Length != 8)
                    {
                        Console.WriteLine("error, there must be 8 values");
                        Environment.Exit(2);
                    }
                   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(3);

            }

            StreamWriter writer = null;

            try
            {
                
                writer = new StreamWriter(Reportfilepath);
                writer.WriteLine("Music Playlist Report");

                var SongsPlays = from song in songs where song.Plays >= 200 select song;
                    writer.WriteLine(report += "Songs that received 200 or more plays:\n");
                    foreach (Songs song in SongsPlays)
                    {
                        writer.WriteLine(report += song + "\n");

                    }
                

                var AltGenre = from song in songs where song.Category is Genre.Alternative select song;
                int i = 0; 
                foreach (Songs song in AltGenre)
                {
                    i++;
                    
                }
                writer.WriteLine("Number of Alternative Songs: {0}", i);

                var HipHopGenre = from song in songs where song.Category is Genre.HipHop select song;
                i = 0;
                foreach (Songs song in HipHopGenre)
                {
                    i++;
                }
                writer.WriteLine("Number of Hip Hop Songs: {0}", i);

                var SongsAlbumFishbowl = from song in songs where song.Album == "Welcome to the Fishbowl" select song;
                foreach(Songs song in SongsAlbumFishbowl)
                {
                    writer.WriteLine(report += song + "\n");
                }

                var Songs1970 = from song in songs where song.Year < 1970 select song;
                foreach(Songs song in Songs1970)
                {
                    writer.WriteLine(report += song + "\n");
                }

                var Names85Characters = from song in songs where song.Name.Length > 85 select song.Name;
                writer.WriteLine(report += "Song names longer than 85 characters:\n");
                foreach (string name in Names85Characters)
                {
                    writer.WriteLine(report += name + "\n"); 
                }

                var LongestSong = from song in songs orderby song.Time descending select song;
                report += "Longest song:\n";
                report += LongestSong.First();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(4);
            }
            finally
            {
                if(File.Exists(Reportfilepath))
                {
                    Console.WriteLine("File was successfully created");
                }
                else
                {
                    Console.WriteLine("file was not saved, u messed up dude");
                }
                if(writer != null)
                {
                    writer.Close();
                }
            }
                Console.ReadKey();
            }
        }
    }

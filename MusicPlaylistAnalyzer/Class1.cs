using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylistAnalyzer
{
    
        public class Songs
        {
            private string _artist;
            private Genre _genre;
            private string _album;
           // private string _genre;
            private int _size;
            private int _time;
            private int _plays;
            private int _year;
        private string _name;

            public Songs(string album, Genre genre, string artist, int size, int time, int plays, int year, string name)
            {
                Album = album;
                //Category = category;
                Artist = artist;
                Category = genre;
                Size = size;
                Time = time;
                Plays = plays;
                Year = year;
                Name = name;
            }

            public string Album
            {
                get { return _album; }
                set
                {
                    _album = value;
                }
            }

            /*public SongCategory Category
            {
                get { return _songcategory; }
                set
                {
                    _songcategory = value;
                }
            }*/

            public string Artist
            {
                get { return _artist; }
                set
                {
                    _artist = value;
                }
            }

            public Genre Category
            {
                get { return _genre; }
                set
                {
                    _genre = value;
                }
            }

            public int Size
            {
                get { return _size; }
                set
                {
                    _size = value;
                }
            }

            public int Time
            {
                get { return _time; }
                set
                {
                    _time = value;
                }
            }
            public int Plays
            {
                get { return _plays; }
                set
                {
                    _plays = value;
                }
            }
            public int Year
            {
                get { return _year; }
                set
                {
                    _year = value;
                }
            }
            public string Name
            {
            get { return _name; }
            set
            {
                _name = value;
            }
            }

        public override string ToString()
            {
                // note: {1:F2} indicates the second variable (first is 0, second is 1) with 2 digits after the decimal point

                return String.Format("Name: {0}, Artist: {1}, Album: {2}, Genre: {3}, Size: {4}, Time: {5}, Year: {6}, Plays: {7} ", Name, Artist, Album, Category, Size, Time, Year, Plays);
            }
        }
    }


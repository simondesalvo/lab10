using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    public class Movie
    {
        #region fields
        private string title;
        private string genre;
        private string opinion;
        #endregion

        #region properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public string Opinion
        {
            get { return opinion; }
            set { opinion = value; }
        }
        #endregion
        #region constructors
        public Movie() { }
        public Movie(string _title, string _genre, string _opinion)
        {
            title = _title;
            genre = _genre;
            opinion = _opinion;
        }
        #endregion

        public void PrintStuff()
        {
            Console.WriteLine($"{title}, {genre}, {opinion}");
        }
    }

}

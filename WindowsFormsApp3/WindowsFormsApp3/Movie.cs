using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Movie
    {
        public static List<Movie> Filmler = new List<Movie>();
        string name;

        public Movie(string _name)
        {
            name = _name;
            Filmler.Add(this);
        }
    }
}

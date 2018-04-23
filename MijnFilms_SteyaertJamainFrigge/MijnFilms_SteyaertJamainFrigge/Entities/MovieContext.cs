using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MijnFilms_SteyaertJamainFrigge.Entities
{
    public class MovieContext
    {
        public MovieContext (List<Movie> MovieList)
        {
            this.MovieList = MovieList;
        }

        public List<Movie> MovieList { get; set; }

        public void Add (Movie Movie)
        {
            MovieList.Add(Movie);
        }
    }

}

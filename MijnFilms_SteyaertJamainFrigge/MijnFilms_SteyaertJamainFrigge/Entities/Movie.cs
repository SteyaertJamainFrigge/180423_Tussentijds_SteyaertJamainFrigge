using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MijnFilms_SteyaertJamainFrigge.Entities
{
    public class Movie
    {
        public Movie(int MovieID, string Title, int Year, int GenreID, int DirectorID, int Stars, string Description)
        {
            this.MovieID = MovieID;
            this.Title = Title;
            this.Year = Year;
            this.GenreID = GenreID;
            this.DirectorID = DirectorID;
            this.Stars = Stars;
            this.Description = Description;
        }
        
        public int MovieID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int GenreID { get; set; }
        public int DirectorID { get; set; }
        public int Stars { get; set; }
        public string Description { get; set; }


    }
}

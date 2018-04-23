using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MijnFilms_SteyaertJamainFrigge.Entities
{
    public class MovieActor
    {
        public MovieActor(int MovieID, int ActorID)
        {
            this.MovieID = MovieID;
            this.ActorID = ActorID;
        }
        public int MovieID { get; set; }
        public int ActorID { get; set; }
    }
}

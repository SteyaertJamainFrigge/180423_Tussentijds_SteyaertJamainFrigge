using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MijnFilms_SteyaertJamainFrigge.Entities
{
    public class Genre
    {
        public Genre (int GenreID, string Description)
        {
            this.GenreID = GenreID;
            this.Description = Description;
        }
        public int GenreID { get; set; }
        public string Description { get; set; }
    }
}

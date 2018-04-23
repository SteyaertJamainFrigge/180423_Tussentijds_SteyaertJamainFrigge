using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MijnFilms_SteyaertJamainFrigge.Entities
{
    public class Person
    {
        public Person(int id, string FirstName, string LastName)
        {
            this.id = id;
            this.LastName = LastName;
            this.FirstName = FirstName;
        }
        public int id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}

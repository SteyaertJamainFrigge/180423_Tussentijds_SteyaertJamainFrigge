using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MijnFilms_SteyaertJamainFrigge.Entities;

namespace MijnFilms_SteyaertJamainFrigge.Controllers
{
    public class MoviesController : Controller
    {
        private List<Movie> Movies { get; set; }
        public MoviesController()
        {
            
        }
        // GET: Movies/List
        public IActionResult List()
        {
            return View(Movies);
        }

        // GET: Movies/Details/
        public IActionResult Details(int id)
        {
            return View(GetDetailsFromMovieID(id));
        }

        private Movie GetDetailsFromMovieID(int id)
        {
            //make connection to db and get movie with specific id
            return new Movie(1, "test", 2007, 2, 1, 5, "this is a description");
        }

        // GET: Movies/Find
        public IActionResult Find(string titel)
        {
            return View();
        }

    }
}
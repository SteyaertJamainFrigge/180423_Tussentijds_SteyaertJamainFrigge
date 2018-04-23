using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MijnFilms_SteyaertJamainFrigge.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/List
        public IActionResult List()
        {
            return View();
        }

        // GET: Movies/Details/
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: Movies/Find
        public IActionResult Find(string titel)
        {
            return View();
        }

    }
}
using System.Text.Encodings.Web;
using bookish.Models;
using Microsoft.AspNetCore.Mvc;

namespace bookish.Controllers
{
    public class MoviesController : Controller
    {
        //GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie(){ Name = "Shrek!" };
            return View();
        }
    }
}

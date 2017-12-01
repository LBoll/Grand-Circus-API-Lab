using MovieGCLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace MovieGCLab.Controllers
{
    public class MovieDBController : ApiController
    {
        [HttpGet]
        public List<Movy> GetMovies()
        {
            MovieDBEntities ORM = new MovieDBEntities();

            return ORM.Movies.ToList();
        }

        [HttpGet]
        public List<Movy> GetMoviesByCategory(string Category)
        {
            MovieDBEntities ORM = new MovieDBEntities();

            return ORM.Movies.Where(x => x.MovieCat.ToLower() == Category.ToLower()).ToList();
        }

        [HttpGet]
        public Movy GetRandomMovie()
        {
            MovieDBEntities ORM = new MovieDBEntities();

            Random random = new Random();

            return ORM.Movies.ToList()[random.Next(ORM.Movies.Count())];
        }

        [HttpGet]
        public List<Movy> GetRandomMoviesByCategory(string Category)
        {
            MovieDBEntities ORM = new MovieDBEntities();

            return ORM.Movies.Where(x => x.MovieCat.ToLower() == Category.ToLower()).ToList();
        }
        /*
        [HttpGet]
        public List<Movy> GetMovieCategories()
        {
            MovieDBEntities ORM = new MovieDBEntities();

            List<Movy> Moviecat = new List<Movy>();

            return ORM.Movies;
        }
        */
        [HttpGet]
        public List<Movy> GetMovieInfo(string Moviename)
        {
            MovieDBEntities ORM = new MovieDBEntities();

            return ORM.Movies.Where(x => x.MovieName.ToLower() == Moviename.ToLower()).ToList();
        }
    }
}

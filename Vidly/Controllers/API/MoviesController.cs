using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class MoviesController: ApiController
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
             _context = new ApplicationDbContext();
        }

        //GET /api/movies 
        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }

        //GET api/movies/{id}
        [HttpGet]
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            
            if(movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            
            return Ok(movie);
        }


        //POST /api/moviesDto/{id}
        [HttpPost]
        public IHttpActionResult CreateMovie(Movie movie)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.Movies.Add(movie);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movie);
        }

        //DELETE /api/customers/{id}
        public IHttpActionResult DeleteMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null)
                return BadRequest();

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();

            return Ok(); //operation was performed successfully 
        }
    }
}
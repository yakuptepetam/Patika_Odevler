using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.MovieOperations.Commands.CreateMovie;
using WebApi.Application.MovieOperations.Commands.DeleteMovie;
using WebApi.Application.MovieOperations.Query.GetMovieDetail;
using WebApi.Application.MovieOperations.Query.GetMovies;
using WebApi.Application.MovieOperations.Commands.UpdateMovie;
using WebApi.DBOperations;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public MovieController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetMovies()
        {
            GetMoviesQuery query = new GetMoviesQuery(_context, _mapper);
            var result = query.Handle();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            GetMovieDetailQuery query = new GetMovieDetailQuery(_context, _mapper);
            MovieDetailViewModel result;
            query.MovieId = id;
            GetMovieDetailQueryValidator validator = new GetMovieDetailQueryValidator();
            validator.ValidateAndThrow(query);
            result = query.Handle();
            return Ok(result);
        }

        // [HttpGet]
        // public Movie Get([FromQuery] string id)
        // {
        //     var movie = MovieList.Where(movie=> movie.Id == Convert.ToInt32(id)).SingleOrDefault();
        //     return movie;
        // }

        [HttpPost]
        public IActionResult AddMovie([FromBody] CreateMovieModel newMovie)
        {
            CreateMovieCommand command = new CreateMovieCommand(_context, _mapper);
            command.Model = newMovie;
            CreateMovieCommandValidator validator = new CreateMovieCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            // if (!result.IsValid)
            // {
            //     foreach (var item in result.Errors)
            //     {
            //         Console.WriteLine("Özellik: " + item.PropertyName + " - Error Message: " + item.ErrorMessage);
            //     }
            // }
            // else
            // {
            //     command.Handle();   
            // }
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, [FromBody] UpdateMovieModel updatedMovie)
        {
            UpdateMovieCommand command = new UpdateMovieCommand(_context);
            command.Model = updatedMovie;
            command.MovieId = id;
            UpdateMovieCommandValidator validator = new UpdateMovieCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            DeleteMovieCommand command = new DeleteMovieCommand(_context);
            command.MovieId = id;
            DeleteMovieCommandValidator validator = new DeleteMovieCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
    }
}
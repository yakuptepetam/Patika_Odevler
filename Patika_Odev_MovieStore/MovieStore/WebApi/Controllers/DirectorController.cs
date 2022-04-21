using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.DirectorOperations.Commands.CreateDirector;
using WebApi.Application.DirectorOperations.Commands.DeleteDirector;
using WebApi.Application.DirectorOperations.Query.GetDirectorDetail;
using WebApi.Application.AutherOperations.Query.GetDirectors;
using WebApi.Application.DirectorOperations.Commands.UpdateDirector;
using WebApi.DBOperations;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class DirectorController : ControllerBase
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public DirectorController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetDirectors()
        {
            GetDirectorsQuery query = new GetDirectorsQuery(_context, _mapper);
            var result = query.Handle();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            GetDirectorDetailQuery query = new GetDirectorDetailQuery(_context, _mapper);
            DirectorDetailViewModel result;
            query.DirectorId = id;
            GetDirectorDetailQueryValidator validator = new GetDirectorDetailQueryValidator();
            validator.ValidateAndThrow(query);
            result = query.Handle();
            return Ok(result);
        }

        // [HttpGet]
        // public Director Get([FromQuery] string id)
        // {
        //     var Director = DirectorList.Where(Director=> Director.Id == Convert.ToInt32(id)).SingleOrDefault();
        //     return Director;
        // }

        [HttpPost]
        public IActionResult AddDirector([FromBody] CreateDirectorModel newDirector)
        {
            CreateDirectorCommand command = new CreateDirectorCommand(_context, _mapper);
            command.Model = newDirector;
            CreateDirectorCommandValidator validator = new CreateDirectorCommandValidator();
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
        public IActionResult UpdateDirector(int id, [FromBody] UpdateDirectorModel updatedDirector)
        {
            UpdateDirectorCommand command = new UpdateDirectorCommand(_context);
            command.Model = updatedDirector;
            command.DirectorId = id;
            UpdateDirectorCommandValidator validator = new UpdateDirectorCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDirector(int id)
        {
            DeleteDirectorCommand command = new DeleteDirectorCommand(_context);
            command.DirectorId = id;
            DeleteDirectorCommandValidator validator = new DeleteDirectorCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
    }
}
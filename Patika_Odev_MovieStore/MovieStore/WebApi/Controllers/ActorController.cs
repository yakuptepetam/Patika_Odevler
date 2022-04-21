using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.ActorOperations.Commands.CreateActor;
using WebApi.Application.ActorOperations.Commands.DeleteActor;
using WebApi.Application.ActorOperations.Query.GetActorDetail;
using WebApi.Application.AutherOperations.Query.GetActors;
using WebApi.Application.ActorOperations.Commands.UpdateActor;
using WebApi.DBOperations;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class ActorController : ControllerBase
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public ActorController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetActors()
        {
            GetActorsQuery query = new GetActorsQuery(_context, _mapper);
            var result = query.Handle();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            GetActorDetailQuery query = new GetActorDetailQuery(_context, _mapper);
            ActorDetailViewModel result;
            query.ActorId = id;
            GetActorDetailQueryValidator validator = new GetActorDetailQueryValidator();
            validator.ValidateAndThrow(query);
            result = query.Handle();
            return Ok(result);
        }

        // [HttpGet]
        // public Actor Get([FromQuery] string id)
        // {
        //     var Actor = ActorList.Where(Actor=> Actor.Id == Convert.ToInt32(id)).SingleOrDefault();
        //     return Actor;
        // }

        [HttpPost]
        public IActionResult AddActor([FromBody] CreateActorModel newActor)
        {
            CreateActorCommand command = new CreateActorCommand(_context, _mapper);
            command.Model = newActor;
            CreateActorCommandValidator validator = new CreateActorCommandValidator();
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
        public IActionResult UpdateActor(int id, [FromBody] UpdateActorModel updatedActor)
        {
            UpdateActorCommand command = new UpdateActorCommand(_context);
            command.Model = updatedActor;
            command.ActorId = id;
            UpdateActorCommandValidator validator = new UpdateActorCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteActor(int id)
        {
            DeleteActorCommand command = new DeleteActorCommand(_context);
            command.ActorId = id;
            DeleteActorCommandValidator validator = new DeleteActorCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
    }
}
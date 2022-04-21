using AutoMapper;
using WebApi.Entities;
using WebApi.Application.GenreOperations.Query.GetGenres;
using WebApi.Application.MovieOperations.Commands.CreateMovie;
using WebApi.Application.MovieOperations.Query.GetMovieDetail;
using WebApi.Application.MovieOperations.Query.GetMovies;
using WebApi.Application.GenreOperations.Query.GetGenreDetail;
using WebApi.Application.GenreOperations.Commands.CreateGenre;
using WebApi.Application.AutherOperations.Query.GetActors;
using WebApi.Application.ActorOperations.Query.GetActorDetail;
using WebApi.Application.ActorOperations.Commands.CreateActor;
using WebApi.Application.DirectorOperations.Commands.CreateDirector;
using WebApi.Application.AutherOperations.Query.GetDirectors;
using WebApi.Application.DirectorOperations.Query.GetDirectorDetail;

namespace WebApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateMovieModel, Movie>();
            CreateMap<Movie, MoviesViewModel>().ForMember(dest=> dest.Genre, opt=> opt.MapFrom(src=> src.Genre.Name)).ForMember(dest=> dest.Actor, opt=> opt.MapFrom(src=> src.Actor.FullName)).ForMember(dest=> dest.Director, opt=> opt.MapFrom(src=> src.Director.FullName));;
            CreateMap<Movie, MovieDetailViewModel>().ForMember(dest=> dest.Genre, opt=> opt.MapFrom(src=> src.Genre.Name)).ForMember(dest=> dest.Actor, opt=> opt.MapFrom(src=> src.Actor.FullName)).ForMember(dest=> dest.Director, opt=> opt.MapFrom(src=> src.Director.FullName));;
       
            
            CreateMap<Genre, GenresViewModel>();
            CreateMap<Genre, GenreDetailViewModel>();
            CreateMap<CreateGenreModel, Genre>();

            CreateMap<Actor, ActorsViewModel>();
            CreateMap<Actor, ActorDetailViewModel>();
            CreateMap<CreateActorModel, Actor>();

            CreateMap<Director, DirectorsViewModel>();
            CreateMap<Director, DirectorDetailViewModel>();
            CreateMap<CreateDirectorModel, Director>();
        }
    }
}
using AutoMapper;
using WebApi.Entities;
using WebApi.Application.GenreOperations.Query.GetGenres;
using WebApi.Application.BookOperations.Commands.CreateBook;
using  WebApi.Application.BookOperations.Query.GetBookDetail;
using  WebApi.Application.BookOperations.Query.GetBooks;
using WebApi.Application.GenreOperations.Query.GetGenreDetail;
using WebApi.Application.GenreOperations.Commands.CreateGenre;
using WebApi.Application.AutherOperations.Query.GetAuthors;
using WebApi.Application.AuthorOperations.Query.GetAuthorDetail;
using WebApi.Application.AuthorOperations.Commands.CreateAuthor;

namespace WebApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateBookModel, Book>();
            CreateMap<Book, BooksViewModel>().ForMember(dest=> dest.Genre, opt=> opt.MapFrom(src=> src.Genre.Name)).ForMember(dest=> dest.Author, opt=> opt.MapFrom(src=> src.Author.FullName));;
            CreateMap<Book, BookDetailViewModel>().ForMember(dest=> dest.Genre, opt=> opt.MapFrom(src=> src.Genre.Name)).ForMember(dest=> dest.Author, opt=> opt.MapFrom(src=> src.Author.FullName));
            // CreateMap<Book, BookDetailViewModel>().ForMember(dest=> dest.Author, opt=> opt.MapFrom(src=> src.Author.FullName));
            // CreateMap<Book, BooksViewModel>().ForMember(dest=> dest.Author, opt=> opt.MapFrom(src=> src.Author.FullName));
            
            CreateMap<Genre, GenresViewModel>();
            CreateMap<Genre, GenreDetailViewModel>();
            CreateMap<CreateGenreModel, Genre>();

            CreateMap<Author, AuthorsViewModel>();
            CreateMap<Author, AuthorDetailViewModel>();
            CreateMap<CreateAuthorModel, Author>();
        }
    }
}
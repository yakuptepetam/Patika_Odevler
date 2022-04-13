using TestSetup;
using System;
using Xunit;
using AutoMapper;
using WebApi.DBOperations;
using WebApi.Application.BookOperations.Commands.CreateBook.CreateBookCommand;

namespace Application.BookOperations.Commands.CreateBook
{
    public class CreateBookCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        
        public CreateBookCommandTests (CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        }
        [Fact]
        public void WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            //arange (Hazırlık)
            var book = new Book()
                    {
                        // Id = 1,
                        Title = "Test_WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeReturn",
                        GenreId = 1, // Personal Growth
                        AuthorId = 1, // Eric Ries
                        PageCount = 100,
                        PublishDate = new DateTime(2022, 06, 12)
                    };
                    _context.Book.Add(book);
                    _context.SaveChanges();
                    CreateBookCommand command = new CreateBookCommand(_context, _mapper);
                    command.Model = new CreateBookComandModel(){Title = book.Title};
                    
                    //act & assert (Çalıştırma & Doğrulama)
                    FluenActions
                                .Invoking(()=> command.Handle())
                                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap Zaten Mevcut.");
        }
        [Fact]
        public void WhenValidInputsAreGiven_Book_ShouldNotBeReturnError()
        {
            //arange (Hazırlık)
            CreateBookCommand command = new CreateBookCommand(_context, _mapper);
            CreateBookModel model = new CreateBookModel()
            {
                Title = "Hobbit",
                GenreId = 1, // Personal Growth
                AuthorId = 1, // Eric Ries
                PageCount = 1000,
                PublishDate = DateTime.Now.Date.AddYears(-10)
            };
            command.Model = model;
            //act (Çalıştırma)
            FluentActions.Invoking()=> command.Handle().Invoke();
            
            //assert (Doğrulama)
            var book = _context.Book.SingleOrDefault(book => book.Title == Model.Title);

            book.Should().NotBeNull();
            book.PageCount.Should().Be(model.PageCount);
            book.PublishDate.Should().Be(model.PublishDate);
            book.GenreId.Should().Be(model.GenreId);
            book.AuthorId.Should().Be(model.AuthorId);

            // CreateBookCommandValidator validator = new CreateBookCommandVelidator();
            // var result = validator.Validate(command);
            // result.Errors.Count.Should().Equals(0);
        }
    }
}
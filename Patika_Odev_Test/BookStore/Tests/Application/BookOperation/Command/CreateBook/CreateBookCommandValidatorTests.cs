using TestSetup;
using System;
using Xunit;
using AutoMapper;
using WebApi.DBOperations;
using WebApi.Application.BookOperations.Commands.CreateBook.CreateBookCommand;

namespace Application.BookOperations.Commands.CreateBook
{
    public class CreateBookCommandValidatorTests : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData("Lord Of The Rings",0,0,0)]
        [InlineData("Lord Of The Rings",0,1,0)]
        [InlineData("",0,0,0)]
        [InlineData("",1,1,100)]
        [InlineData("",1,0,0)]
        [InlineData("",0,1,0)]
        [InlineData("",0,0,1)]
        [InlineData("Lor",1,0,0)]
        [InlineData("Lor",1,1,1)]
        [InlineData("Lord",0,1,0)]
        [InlineData("Lord",0,0,1)]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(string title, int genreId, int authorId, int pageCount)
        {
            CreateBookCommand command = new CreateBookCommand(_context, _mapper);
            command.Model = new CreateBookComandModel()
            {
                Title = title,
                GenreId = genreId, // Personal Growth
                AuthorId = authorId, // Eric Ries
                PageCount = pageCount,
                PublishDate = DateTime.Now.Date.AddYears(-1)
            };

            CreateBookCommandValidator validator = new CreateBookCommandVelidator();
            var result = validator.Validate(command);
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnError()
        {
            CreateBookCommand command = new CreateBookCommand(_context, _mapper);
            command.Model = new CreateBookComandModel()
            {
                Title = "Lord Of Rings",
                GenreId = 1, // Personal Growth
                AuthorId = 1, // Eric Ries
                PageCount = 500,
                PublishDate = DateTime.Now.Date
            };
            CreateBookCommandValidator validator = new CreateBookCommandVelidator();
            var result = validator.Validate(command);
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnError()
        {
            CreateBookCommand command = new CreateBookCommand(_context, _mapper);
            command.Model = new CreateBookComandModel()
            {
                Title = "Lord Of Rings",
                GenreId = 1, // Personal Growth
                AuthorId = 1, // Eric Ries
                PageCount = 500,
                PublishDate = DateTime.Now.Date.AddYears(-2)
            };
            CreateBookCommandValidator validator = new CreateBookCommandVelidator();
            var result = validator.Validate(command);
            result.Errors.Count.Should().Equals(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Book_ShouldNotBeReturnError()
        {
            CreateBookCommand command = new CreateBookCommand(_context, _mapper);
            command.Model = new CreateBookComandModel()
            {
                Title = "Hobbit",
                GenreId = 1, // Personal Growth
                AuthorId = 1, // Eric Ries
                PageCount = 1000,
                PublishDate = DateTime.Now.Date.AddYears(-10)
            };
            CreateBookCommandValidator validator = new CreateBookCommandVelidator();
            var result = validator.Validate(command);
            result.Errors.Count.Should().Equals(0);
        }
    }
}
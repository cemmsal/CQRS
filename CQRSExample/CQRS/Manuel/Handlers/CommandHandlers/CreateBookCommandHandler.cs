using CQRSExample.CQRS.Manuel.Commands.Request;
using CQRSExample.CQRS.Manuel.Commands.Response;
using CQRSExample.Data;
using System;

namespace CQRSExample.CQRS.Manuel.Handlers.CommandHandlers
{ 
    public class CreateBookCommandHandler
    {
        public CreateBookCommandResponse CreateBook(CreateBookCommandRequest createBookCommandRequest)
        {
            var id = Guid.NewGuid();
            AppDbContext.BookList.Add(new()
            {
                Id = id,
                Name = createBookCommandRequest.Name,
                Author = createBookCommandRequest.Author,
                Price = createBookCommandRequest.Price,
                Qty = createBookCommandRequest.Qty,
                CreatedDate = DateTime.Now
            });
            return new CreateBookCommandResponse
            {
                IsSuccess = true,
                BookId = id
            };
        }
    }
}

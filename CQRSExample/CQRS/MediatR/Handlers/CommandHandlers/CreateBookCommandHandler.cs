using CQRSExample.CQRS.MediatR.Commands.Request;
using CQRSExample.CQRS.MediatR.Commands.Response;
using CQRSExample.Data;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSExample.CQRS.MediatR.Handlers.CommandHandlers
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommandMediatrRequest, CreateBookCommandResponse>
    {
        public async Task<CreateBookCommandResponse> Handle(CreateBookCommandMediatrRequest request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            AppDbContext.BookList.Add(new()
            {
                Id = id,
                Name = request.Name,
                Author = request.Author,
                Price = request.Price,
                Qty = request.Qty,
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

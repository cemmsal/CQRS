using CQRSExample.CQRS.MediatR.Queries.Request;
using CQRSExample.CQRS.MediatR.Queries.Response;
using CQRSExample.Data;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSExample.CQRS.MediatR.Handlers.QueryHandlers
{
    public class GetByIdBookQueryHandler : IRequestHandler<GetByIdBookQueryMediatrRequest, GetByIdBookQueryResponse>
    {
        public async Task<GetByIdBookQueryResponse> Handle(GetByIdBookQueryMediatrRequest request, CancellationToken cancellationToken)
        {
            var book = AppDbContext.BookList.FirstOrDefault(p => p.Id == request.Id);
            return new GetByIdBookQueryResponse
            {
                Id = book.Id,
                Name = book.Name,
                Author = book.Author,
                Price = book.Price,
                Qty = book.Qty,
                CreatedDate = book.CreatedDate
            };
        }
    }
}

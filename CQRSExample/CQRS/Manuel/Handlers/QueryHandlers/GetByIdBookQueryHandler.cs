using CQRSExample.CQRS.Manuel.Queries.Request;
using CQRSExample.CQRS.Manuel.Queries.Response;
using CQRSExample.Data;
using System.Linq;

namespace CQRSExample.CQRS.Manuel.Handlers.QueryHandlers
{
    public class GetByIdBookQueryHandler
    {
        public GetByIdBookQueryResponse GetByIdBook(GetByIdBookQueryRequest getByIdBookQueryRequest)
        {
            var book = AppDbContext.BookList.FirstOrDefault(p => p.Id == getByIdBookQueryRequest.Id);
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

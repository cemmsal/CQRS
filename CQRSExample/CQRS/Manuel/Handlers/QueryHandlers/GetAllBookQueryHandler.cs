using CQRSExample.CQRS.Manuel.Queries.Request;
using CQRSExample.CQRS.Manuel.Queries.Response;
using CQRSExample.Data;
using System.Collections.Generic;
using System.Linq;

namespace CQRSExample.CQRS.Manuel.Handlers.QueryHandlers
{
    public class GetAllBookQueryHandler
    {
        public List<GetAllBookQueryResponse> GetAllBook(GetAllBookQueryRequest getAllBookQueryRequest)
        {
            return AppDbContext.BookList.Select(book => new GetAllBookQueryResponse
            {
                Id = book.Id,
                Name = book.Name,
                Author = book.Author,
                Price = book.Price,
                Qty = book.Qty,
                CreatedDate = book.CreatedDate
            }).ToList();
        }
    }
}

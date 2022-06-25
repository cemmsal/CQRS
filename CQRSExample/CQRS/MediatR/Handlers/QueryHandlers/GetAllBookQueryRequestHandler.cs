using CQRSExample.CQRS.MediatR.Queries.Request;
using CQRSExample.CQRS.MediatR.Queries.Response;
using CQRSExample.Data;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSExample.CQRS.MediatR.Handlers.QueryHandlers
{
    public class GetAllBookQueryRequestHandler : IRequestHandler<GetAllBookQueryMediatrRequest, List<GetAllBookQueryResponse>>
    {
        public async Task<List<GetAllBookQueryResponse>> Handle(GetAllBookQueryMediatrRequest request, CancellationToken cancellationToken)
        {
            return AppDbContext.BookList.Select(product => new GetAllBookQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Author = product.Author,
                Price = product.Price,
                Qty = product.Qty,
                CreatedDate = product.CreatedDate
            }).ToList();
        }
    }
}

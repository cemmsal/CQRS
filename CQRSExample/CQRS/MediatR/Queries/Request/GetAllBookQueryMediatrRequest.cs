using CQRSExample.CQRS.MediatR.Queries.Response;
using MediatR;
using System.Collections.Generic;

namespace CQRSExample.CQRS.MediatR.Queries.Request
{
    public class GetAllBookQueryMediatrRequest : IRequest<List<GetAllBookQueryResponse>>
    {
    }
}

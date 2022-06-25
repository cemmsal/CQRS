using CQRSExample.CQRS.MediatR.Queries.Response;
using MediatR;
using System;

namespace CQRSExample.CQRS.MediatR.Queries.Request
{
    public class GetByIdBookQueryMediatrRequest : IRequest<GetByIdBookQueryResponse>
    {
        public Guid Id { get; set; }
    }
}

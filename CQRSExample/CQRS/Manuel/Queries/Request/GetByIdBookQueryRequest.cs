using System;

namespace CQRSExample.CQRS.Manuel.Queries.Request
{
    public class GetByIdBookQueryRequest
    { 
        public Guid Id { get; set; }
    }
}

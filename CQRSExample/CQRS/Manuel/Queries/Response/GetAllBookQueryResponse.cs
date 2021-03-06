using System;

namespace CQRSExample.CQRS.Manuel.Queries.Response
{
    public class GetAllBookQueryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

using CQRSExample.CQRS.MediatR.Commands.Response;
using MediatR;

namespace CQRSExample.CQRS.MediatR.Commands.Request
{
    public class CreateBookCommandMediatrRequest : IRequest<CreateBookCommandResponse>
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
    }
}

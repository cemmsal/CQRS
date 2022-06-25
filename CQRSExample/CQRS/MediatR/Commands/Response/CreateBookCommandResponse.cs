using System;

namespace CQRSExample.CQRS.MediatR.Commands.Response
{
    public class CreateBookCommandResponse
    {
        public bool IsSuccess { get; set; }
        public Guid BookId { get; set; }
    }
}

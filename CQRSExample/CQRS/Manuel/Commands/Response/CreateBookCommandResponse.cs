using System;

namespace CQRSExample.CQRS.Manuel.Commands.Response
{
    public class CreateBookCommandResponse
    {
        public bool IsSuccess { get; set; }
        public Guid BookId { get; set; }
    }
}

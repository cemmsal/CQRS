using CQRSExample.CQRS.MediatR.Commands.Request;
using CQRSExample.CQRS.MediatR.Commands.Response;
using CQRSExample.CQRS.MediatR.Queries.Request;
using CQRSExample.CQRS.MediatR.Queries.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookMediatRController : ControllerBase
    {
        IMediator _mediator;
        public BookMediatRController(
            IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllBookQueryMediatrRequest requestModel)
        {
            List<GetAllBookQueryResponse> allBooks = await _mediator.Send(requestModel);
            return Ok(allBooks);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            GetByIdBookQueryResponse book = await _mediator.Send(new GetByIdBookQueryMediatrRequest{ Id = id});
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateBookCommandMediatrRequest requestModel)
        {
            CreateBookCommandResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}

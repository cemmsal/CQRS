using CQRSExample.CQRS.Manuel.Commands.Request;
using CQRSExample.CQRS.Manuel.Commands.Response;
using CQRSExample.CQRS.Manuel.Handlers.CommandHandlers;
using CQRSExample.CQRS.Manuel.Handlers.QueryHandlers;
using CQRSExample.CQRS.Manuel.Queries.Request;
using CQRSExample.CQRS.Manuel.Queries.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CQRSExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookManuelController : ControllerBase
    {
        CreateBookCommandHandler _createBookCommandHandler;
        GetAllBookQueryHandler _getAllBookQueryHandler;
        GetByIdBookQueryHandler _getByIdBookQueryHandler;
        public BookManuelController(
            CreateBookCommandHandler createBookCommandHandler,
            GetAllBookQueryHandler getAllBookQueryHandler,
            GetByIdBookQueryHandler getByIdBookQueryHandler)
        {
            _createBookCommandHandler = createBookCommandHandler;
            _getAllBookQueryHandler = getAllBookQueryHandler;
            _getByIdBookQueryHandler = getByIdBookQueryHandler;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] GetAllBookQueryRequest requestModel)
        {
            List<GetAllBookQueryResponse> allBooks = _getAllBookQueryHandler.GetAllBook(requestModel);
            return Ok(allBooks);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {            
            GetByIdBookQueryResponse book = _getByIdBookQueryHandler.GetByIdBook(new GetByIdBookQueryRequest { Id = id });
            return Ok(book);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateBookCommandRequest requestModel)
        {
            CreateBookCommandResponse response = _createBookCommandHandler.CreateBook(requestModel);
            return Ok(response);
        }
    }
}

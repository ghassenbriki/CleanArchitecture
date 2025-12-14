using CleanArchitecture.application.DTO;
using CleanArchitecture.application.Feature.productFeature.request.commands;
using CleanArchitecture.application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Reflection.Metadata.Ecma335;

namespace presentation.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("addproduct")]
          public async  Task<ActionResult<CommandResult>> addProduct([FromBody] ProductDto p)
           {
            var createCmdProduct = new CreateProductCommand() { productDto = p };   
            var res = await _mediator.Send(createCmdProduct);

            if (res.Errors != null && res.Errors.Any())
                return BadRequest(res);   

            return Ok(res);
        }
          

         







    }  

    
}

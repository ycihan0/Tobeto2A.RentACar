using Application.Features.Brands.Commands.Create;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BrandController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatedBrandCommand command)
    {
        CreatedBrandResponse response = await Mediator.Send(command);
        return Created(response);
    }
}

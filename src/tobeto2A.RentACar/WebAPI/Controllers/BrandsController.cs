using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Queries.GetList;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BrandsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBrandCommand command)
    {
        CreatedBrandResponse response = await Mediator.Send(command);//mediator burada yönlendirme yapar HAndler fonksiyonunu otomatik kendisi bulacaktır.
        return Created("", response);

    }
    [HttpGet]
    public async Task<IActionResult> GetAll([FromBody] PageRequest pageRequest)
    {
        GetListBrandQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListBrandItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }
}

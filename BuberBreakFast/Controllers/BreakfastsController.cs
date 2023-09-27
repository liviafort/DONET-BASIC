using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Contracts.Breakfast;
using BuberBraskfast.Models;
namespace BuberBreakfast.Controller;

[ApiController]
[Route("[controller]")]
//[Route("breakfasts")]
public class BreakfastsController : ControllerBase{
 
    //CRIAÇÃO DE ROTAS
    [HttpPost()]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request){

        Breakfast breakfast = new Breakfast(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.UtcNow,
            request.Savory,
            request.Sweet
        );

        BreakfastResponse response = new BreakfastResponse(
            breakfast.Id,
            breakfast.Name,
            breakfast.Description,
            breakfast.EndDateTime,
            breakfast.StartDateTime,
            breakfast.LastModifiedDateTime,
            breakfast.Savory,
            breakfast.Sweet
        );
        return Ok(request);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBreakfast(Guid id){
        return Ok(id);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request){
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id){
        return Ok(id);
    }
}  
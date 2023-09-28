using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Contracts.Breakfast;
using BuberBraskfast.Models;
using BuberBreakfast.Services.Breakfasts;
namespace BuberBreakfast.Controller;

[ApiController]
[Route("[controller]")]
//[Route("breakfasts")]
public class BreakfastsController : ControllerBase{
 
    //CHAMADA DOS SERVICES
    private readonly IBreakfastService _breakfastService;
    public BreakfastsController(IBreakfastService breakfastService){
        _breakfastService = breakfastService;
    }

    //CRIAÇÃO DE ROTAS
    [HttpPost()]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request){

        Breakfast breakfast = new(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.UtcNow,
            request.Savory,
            request.Sweet
        );

        _breakfastService.CreateBreakfast(breakfast);

        BreakfastResponse response = new(
            breakfast.Id,
            breakfast.Name,
            breakfast.Description,
            breakfast.EndDateTime,
            breakfast.StartDateTime,
            breakfast.LastModifiedDateTime,
            breakfast.Savory,
            breakfast.Sweet
        );
        return CreatedAtAction(
            nameof(GetBreakfast),
            routeValues: new { id = breakfast.Id},
            value: response);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBreakfast(Guid id){
        Breakfast breakfast = _breakfastService.GetBreakfast(id);
        return Ok(id);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request){
        Breakfast breakfast = new(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.UtcNow,
            request.Savory,
            request.Sweet
        );

        _breakfastService.UpsertBreakfast(breakfast);

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id){
        _breakfastService.DeleteBreakfast(id);
        return NoContent();
    }
}  
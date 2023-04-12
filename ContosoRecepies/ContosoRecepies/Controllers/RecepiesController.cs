using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoRecepies.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecepiesController : ControllerBase
{
    [HttpGet]
    public ActionResult GetRecepies([FromQuery]int count)
    {
        string[] recepies = { "Oxtail", "Curry Chicken", "Dumplings"};

        if (!recepies.Any())
        {
            return NotFound();
        }
        return Ok(recepies.Take(count));
        
    }

    //[HttpPost]
    //public ActionResult CreateNewRecepies() { }

    [HttpDelete]
    public ActionResult DeleteRecepies(string id) 
    {
        bool badThingsHappned = false;
        if(badThingsHappned)
        {
            return BadRequest();
        }
        return NoContent();
    }
}

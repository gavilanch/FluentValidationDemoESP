using Microsoft.AspNetCore.Mvc;

namespace FluentValidationDemo.Controllers
{
    [Route("api/personas")]
    [ApiController]
    public class PersonasController: ControllerBase
    {
        [HttpPost]
        public ActionResult Post(Persona persona)
        {
            return Ok();
        }
    }
}

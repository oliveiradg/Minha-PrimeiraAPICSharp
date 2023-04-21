using Microsoft.AspNetCore.Mvc;
using MinhaApi.models;

namespace MinhaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuarioController : Controller
    {
      [HttpGet]
      public ActionResult<List<usuarioModel>> BuscarTodosUsuarios()
        {
            return Ok();
        }
    }
}

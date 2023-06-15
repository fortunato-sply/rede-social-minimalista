using temp.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
namespace ProjetoWeb.Controllers;

[ApiController]
[Route("message")]

public class MesssageController : ControllerBase
{
  [HttpGet]
  [EnableCors("MainPolicy")]
  public async Task<ActionResult<IEnumerable<Mensagem>>> GetAll(
    [FromServices] IRepository<Mensagem> repo
  )
  {
    var result = await repo.Filter(x => true);
    return result;
  }

  [HttpPost]
  [EnableCors("MainPolicy")]
  public async Task<ActionResult> Add(
    [FromBody] Mensagem message,
    [FromServices] IRepository<Mensagem> repo
  )
  {
    repo.Add(message);
    return Ok();
  }
}
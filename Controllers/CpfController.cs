using Microsoft.AspNetCore.Mvc;

namespace temp.Controllers;
using Microsoft.AspNetCore.Mvc;
 
[ApiController]
[Route("cpf")]
public class CpfController : ControllerBase
{
    [HttpGet("{cpf}")]
    public ActionResult<Cpf> Get(string cpf)
    {
        Cpf result = new Cpf();
		
        try
        {
            result.Value = cpf;
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
 
        return result;
    }
	
    // Usa um serviço usando o atributo FromServices que foi cadastrado no Program.cs
    [HttpGet("generate/{region}")]
    public ActionResult<Cpf> Generate(
		[FromServices]CpfService cpf, int region)
    {
        var result = cpf.Generate(region);
  
        return result;
    }
}

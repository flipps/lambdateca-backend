using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LambdaTeca.API.Controllers
{
    public class LivrosController : Controller
    {
        // GET
        [HttpGet("/livros")]
        public IActionResult ObterLivros()
        {
            return Ok("Works!");
        }

    }
}
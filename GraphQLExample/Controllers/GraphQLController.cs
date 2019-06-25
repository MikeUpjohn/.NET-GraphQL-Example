using GraphQLExample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GraphQLExample.Controllers
{
    [Route("api/[controller]")]
    public class GraphQLController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> GraphQLPost([FromBody] GraphQLQuery query)
        {
            return Ok();
        }
    }
}

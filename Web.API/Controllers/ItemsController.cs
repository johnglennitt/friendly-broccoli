using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.API.Data;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private EfContext context;

        public ItemsController(EfContext context)
        {
            this.context = context;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ItemEntity), 200)]
        [ProducesErrorResponseType(typeof(BadRequestResult))]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var item = await context.Items.FindAsync(id);

            if (item == null)
                return BadRequest();

            else
                return Ok(item);
        }

        [HttpGet()]
        [ProducesResponseType(typeof(ItemEntity[]), 200)]
        [ProducesErrorResponseType(typeof(BadRequestResult))]
        public async Task<IActionResult> GetAll()
        {
            var items = await context.Items.ToArrayAsync();

            return Ok(items);
        }
    }
}

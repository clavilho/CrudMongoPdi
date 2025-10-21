using CrudMongo.Entities;
using CrudMongo.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly MongoDbService mongoDbService;

        public UserController(MongoDbService mongoDbService)
        {
            this.mongoDbService = mongoDbService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {

            await mongoDbService.CreateAsync(user);
            return Ok(user);

        }

        [HttpDelete("/{id}")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            await mongoDbService.DeleteAsync(id);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await mongoDbService.GetAllAsync();
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] string id, [FromBody] User user)
        {
            await mongoDbService.UpdateAsync(id, user);
            return Ok();
        }
    }
}

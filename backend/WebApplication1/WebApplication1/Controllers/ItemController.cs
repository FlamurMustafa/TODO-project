using Microsoft.AspNetCore.Mvc;
using WebApplication1.models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("items")]

    public class ItemController : ControllerBase
    {
        private readonly ItemRepo _repository = new ItemRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetAllItems()
        {
            var items = _repository.getItems();

            return Ok(items);
        }
        //[HttpGet("{id}")]
        //public ActionResult<Item> GetItemById(int id)
        //{

        //}
    }



}

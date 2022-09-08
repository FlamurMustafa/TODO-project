using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Reflection;
using System.Text.Json.Nodes;
using WebApplication1.models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("items")]

    public class ItemController : ControllerBase
    {
        private readonly ItemRepo _repository = new ItemRepo();

        [HttpPost]
        public ActionResult<Item> CreateItem([FromBody]CreateItemModel item)
        {
            var itemCreated = _repository.CreateItem(item);
            if (itemCreated != null) 
                return Created($"~items/{itemCreated.Name}", itemCreated); ;

            return BadRequest();
        }


        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetAllItems()
        {
            var items = _repository.getItems();

            return Ok(items);
        }
        //[HttpGet("{itemName}")]
        //public ActionResult<Item> GetItemById(String itemName)
        //{
        //    var item = _repository.getItemById(itemName);

        //    return Ok(item);

        //}

        [HttpPut("{itemName}")]
        public  ActionResult UpdateItem([FromBody] Item item, string itemName)
        {
            int rows = _repository.UpdateItem(item, itemName);
            if (rows == 1) return NoContent();
            else return NotFound();
        }

        [HttpDelete("{itemName}")]
        public ActionResult<int> DeleteItemByName(string itemName)
        {
            _repository.deleteItemByName(itemName);
            return Ok(200);
        }
    }
}

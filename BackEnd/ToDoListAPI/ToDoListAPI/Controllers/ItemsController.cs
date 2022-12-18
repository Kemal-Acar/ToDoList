namespace ToDoListAPI.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using ToDoList.Core.Model;
    using ToDoListAPI.Mediator;

    [ApiController]
    [Route("[controller]")]
    public class ItemsController :ControllerBase
    {
        private readonly IMediator mediator;

        public ItemsController(
            IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost()]
        public async Task<IActionResult> AddItem(ItemEntity item)
        {
            await this.mediator.Send(new AddItemRequest(item));
            return this.CreatedAtRoute("GetItemById", new { id = item.Id }, item);
        }

        [HttpGet()]
        public async Task<IActionResult> GetItems()
        {
            var items = await this.mediator.Send(new GetItemsRequest());
            return this.Ok(items);
        }

        [HttpGet("{id}", Name ="GetItemById")]
        public IActionResult GetItem(string id)
        {
            return this.Ok(this.mediator.Send(new GetItemRequest(id)));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteItem(string id)
        {
            this.mediator.Send(new DeleteItemRequest(id));
            return this.NoContent();
        }

        [HttpPut]
        public IActionResult UpdateItem(ItemEntity item)
        {
            this.mediator.Send(new UpdateItemRequest(item));
            return(this.Ok(item));
        }

    }
}

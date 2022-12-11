namespace ToDoListAPI.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> AddItem(string name)
        {
            await this.mediator.Send(new AddItemRequest(name));
            return this.Ok();
        }

        [HttpGet()]
        public async Task<IActionResult> GetItems()
        {
            var items = await this.mediator.Send(new GetItemRequest());
            return this.Ok(items);
        }

    }
}

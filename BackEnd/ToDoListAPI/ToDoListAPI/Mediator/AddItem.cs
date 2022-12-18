namespace ToDoListAPI.Mediator
{
    using MediatR;
    using ToDoList.Core.Interfaces;
    using ToDoList.Core.Model;

    public class AddItemRequest : IRequest {

        public AddItemRequest(ItemEntity item)
        {
            this.Item = item;
        }

        public ItemEntity Item { get; set; }

        public class AddItemRequestHandler : AsyncRequestHandler<AddItemRequest>
        {
            private readonly IItemService itemService;

            public AddItemRequestHandler(IItemService itemService)
            {
                this.itemService = itemService;
            }
            protected override async Task Handle(AddItemRequest request, CancellationToken cancellationToken)
            {
                itemService.AddItem(request.Item);
            }
        }
    }

}

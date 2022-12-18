namespace ToDoListAPI.Mediator
{
    using MediatR;
    using ToDoList.Core.Interfaces;
    using ToDoList.Core.Model;

    public class UpdateItemRequest : IRequest
    {

        public UpdateItemRequest(ItemEntity item)
        {
            this.Item = item;
        }

        public ItemEntity Item { get; set; }

        public class UpdateItemRequestHandler : AsyncRequestHandler<UpdateItemRequest>
        {
            private readonly IItemService itemService;

            public UpdateItemRequestHandler(IItemService itemService)
            {
                this.itemService = itemService;
            }
            protected override async Task Handle(UpdateItemRequest request, CancellationToken cancellationToken)
            {
                itemService.GetItem(request.Item.Id);
                itemService.UpdateItem(request.Item);
            }
        }
    }

}

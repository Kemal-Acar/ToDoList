namespace ToDoListAPI.Mediator
{
    using MediatR;
    using ToDoList.Core.Interfaces;
    using ToDoList.Core.Model;

    public class GetItemRequest : IRequest<ItemEntity>
    {
        public string Id { get; set; }

        public GetItemRequest(string id)
        {
            this.Id = id;
        }
        public class GetItemRequestHandler : IRequestHandler<GetItemRequest, ItemEntity>
        {
            private readonly IItemService itemService;

            public GetItemRequestHandler(IItemService itemService)
            {
                this.itemService = itemService;
            }
            public async Task<ItemEntity> Handle(GetItemRequest request, CancellationToken cancellationToken)
            {
                return this.itemService.GetItem(request.Id);
            }
        }
    }
}

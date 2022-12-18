namespace ToDoListAPI.Mediator
{
    using MediatR;
    using ToDoList.Core.Interfaces;
    using ToDoList.Core.Model;

    public class GetItemsRequest : IRequest<List<ItemEntity>>
    {
        public class GetItemsRequestHandler : IRequestHandler<GetItemsRequest, List<ItemEntity>>
        {
            private readonly IItemService itemService;

            public GetItemsRequestHandler(IItemService itemService)
            {
                this.itemService = itemService;
            }
            public async Task<List<ItemEntity>> Handle(GetItemsRequest request, CancellationToken cancellationToken)
            {
                return this.itemService.GetItems();
            }
        }


    }
}

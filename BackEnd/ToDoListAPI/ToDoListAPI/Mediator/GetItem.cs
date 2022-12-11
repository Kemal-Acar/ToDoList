namespace ToDoListAPI.Mediator
{
    using MediatR;
    using ToDoList.Core.Interfaces;
    using ToDoList.Core.Model;

    public class GetItemRequest : IRequest<List<ItemEntity>>
    {

        public class GetItemRequestHandler : IRequestHandler<GetItemRequest, List<ItemEntity>>
        {
            private readonly IItemService itemService;

            public GetItemRequestHandler(IItemService itemService)
            {
                this.itemService = itemService;
            }
            public async Task<List<ItemEntity>> Handle(GetItemRequest request, CancellationToken cancellationToken)
            {
                await Task.Delay(500);
                return this.itemService.GetItems();
            }

           
        }
    }

}

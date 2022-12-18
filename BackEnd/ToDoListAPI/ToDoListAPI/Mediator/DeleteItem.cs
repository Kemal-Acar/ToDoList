namespace ToDoListAPI.Mediator
{
    using MediatR;
    using ToDoList.Core.Interfaces;
    using ToDoList.Core.Model;

    public class DeleteItemRequest : IRequest
    {

        public DeleteItemRequest(string id)
        {
            this.Id = id;
        }

        public string Id { get; set; }

        public class DeleteItemRequestHandler : AsyncRequestHandler<DeleteItemRequest>
        {
            private readonly IItemService itemService;

            public DeleteItemRequestHandler(IItemService itemService)
            {
                this.itemService = itemService;
            }
            protected override async Task Handle(DeleteItemRequest request, CancellationToken cancellationToken)
            {
                itemService.DeleteItem(request.Id);
            }
        }
    }

}

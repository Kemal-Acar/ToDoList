namespace ToDoListAPI.Mediator
{
    using MediatR;

    public class AddItemRequest : IRequest {

        public AddItemRequest(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public class AddItemRequestHandler : AsyncRequestHandler<AddItemRequest>
        {
            protected override async Task Handle(AddItemRequest request, CancellationToken cancellationToken)
            {
                var name = request.Name;
                await Task.Delay(500);
            }
        }
    }

}

using Contracts;

namespace Mediator.BlazorApp.Client.Handlers
{

    public sealed class TestClientHandler : IRequestHandler<TestRequest, TestResponse>
    {
        public ValueTask<TestResponse> Handle(TestRequest request, CancellationToken cancellationToken)
        {
            // TODO: forward request to API;
            return ValueTask.FromResult(new TestResponse("client generated response for " + request.Test));
        }
    }

}

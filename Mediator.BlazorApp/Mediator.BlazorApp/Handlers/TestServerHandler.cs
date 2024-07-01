using Contracts;

namespace Mediator.BlazorApp.Client.Handlers
{

    public sealed class TestServerHandler : IRequestHandler<TestRequest, TestResponse>
    {
        public ValueTask<TestResponse> Handle(TestRequest request, CancellationToken cancellationToken)
        {
            // TODO: do some server side logic here
            return ValueTask.FromResult(new TestResponse("server generated response for " + request.Test));
        }
    }

}

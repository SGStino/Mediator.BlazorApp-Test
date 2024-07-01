namespace Contracts
{
    public record TestRequest(string Test) : Mediator.IRequest<TestResponse>;
}

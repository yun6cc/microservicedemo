using System.Threading.Tasks;
using Grpc.Core;
using GrpcTest;

namespace MicroService.GRpcService.Services
{
    public class TestService : Test.TestBase
    {
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}
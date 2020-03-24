using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcTest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroService.GRpcWebClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly Test.TestClient _testClient;

        public TestController(Test.TestClient testClient)
        {
            _testClient = testClient;
        }

        [Route("get")]
        public async Task<string> Get(string name)
        {
            var res = await _testClient.SayHelloAsync(new HelloRequest() { Name = name });
            return res.Message;
        }
    }
}
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VapeShopeSite.Domain.Handlers.TestHandler;
using VapeShopeSite.Domain.Models;
using VapeShopSite.Common.Infrastructure;

namespace VapeShopeSite.WebApi.Controllers.TestController
{
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IHandlerProvider _handlerProvider;

        public TestController(IHandlerProvider handlerProvider)
        {
            _handlerProvider = handlerProvider;
        }

        [HttpGet("/{id}")]
        public async Task<string> Get(string id)
        {
            var  result = await _handlerProvider.HandleAsync<TestRequest, TestDomainEntity>(new TestRequest{Id = id});
            return result.Result;
        }
    }
}
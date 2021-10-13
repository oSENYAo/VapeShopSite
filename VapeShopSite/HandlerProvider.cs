using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using VapeShopSite.Common.Infrastructure;

namespace VapeShopeSite.WebApi
{
    public class HandlerProvider : IHandlerProvider
    {
        private readonly IServiceProvider _services;

        public HandlerProvider(IServiceProvider services)
        {
            _services = services;
        }

        public Task<TResponce> HandleAsync<TRequest, TResponce>(TRequest request) where TRequest : IRequest<TResponce>
        {
            return _services.GetService<IRequestHandler<TRequest, TResponce>>()?.HandleAsync(request);
        }

        public Task HandleAsync<TCommand>(TCommand command) where TCommand : ICommand
        {
            return _services.GetService<ICommandHandler<TCommand>>()?.HandleAsync(command);
        }
    }
}
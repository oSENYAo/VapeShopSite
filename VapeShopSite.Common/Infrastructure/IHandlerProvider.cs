using System.Threading.Tasks;

namespace VapeShopSite.Common.Infrastructure
{
    public interface IHandlerProvider
    {
        Task<TResponce> HandleAsync<TRequest, TResponce>(TRequest request) where TRequest : IRequest<TResponce>;
        Task HandleAsync<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
using System.Threading.Tasks;

namespace VapeShopSite.Common.Infrastructure
{
    public interface IRequestHandler<in TRequest, TResponce> where TRequest : IRequest<TResponce>
    {
        Task<TResponce> HandleAsync(TRequest request);
    }
}
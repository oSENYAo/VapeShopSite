using System.Threading.Tasks;

namespace VapeShopSite.Common.Infrastructure
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand

    {
    Task HandleAsync(TCommand command);
    }
}
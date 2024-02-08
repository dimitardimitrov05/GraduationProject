using Резервирай_Преживяване.Models.Account;

namespace Резервирай_Преживяване.Contracts
{
    public interface IAccountService
    {
        Task<IEnumerable<RegisterViewModel>> CreateUserAsync();
    }
}

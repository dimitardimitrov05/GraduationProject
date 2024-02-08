using Microsoft.AspNetCore.Identity;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Data;
using Резервирай_Преживяване.Data.Account;
using Резервирай_Преживяване.Models.Account;

namespace Резервирай_Преживяване.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AccountService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<IEnumerable<RegisterViewModel>> CreateUserAsync()
        {
            return null;
        }
    }
}

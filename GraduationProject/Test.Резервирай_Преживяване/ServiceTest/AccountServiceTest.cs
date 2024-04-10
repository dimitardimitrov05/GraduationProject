using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Резервирай_Преживяване.Mock;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Data.Account;
using Резервирай_Преживяване.Services;

namespace Test.Резервирай_Преживяване.ServiceTest
{
    [TestFixture]
    public class AccountServiceTest
    {
        [Test]
        public void ChangePicture_ThrowsNullExceptionsIfUrlIsNull()
        {
            using var data = DatabaseMock.Instance;
            var userId = Guid.NewGuid().ToString();
            data.Users.Add(new User
            {
                Id = userId,
                FirstName = "test",
                LastName = "test",
                UserName = "test",
                Email = "test",
            });
            data.SaveChanges();

            var accountService = new AccountService(data);

            var ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await accountService.ChangeProfilePicture(userId, null));
        }
    }
}

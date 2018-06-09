using System.Linq;
using StockMarket.Data;
using StockMarket.Data.Models;
using StockMarket.ViewModels;

namespace StockMarket.Services
{
    public class UserAccountData : IUserAccountData
    {
        private readonly StockMarketContext _context;

        public UserAccountData(StockMarketContext context)
        {
            _context = context;
        }

        public UserAccount Add(UserAccount userAccount)
        {
            _context.UserAccounts.Add(userAccount);
            _context.SaveChanges();

            return userAccount;
        }

        public UserAccountsListViewModel GetAllUserAccounts()
        {
            var query = GetUserAccounts();
            var vm = new UserAccountsListViewModel();

            if (!query.Any()) return vm;

            foreach (var model in query)
            {
                var userAccount = Map(model);
                vm.UserAccounts.Add(userAccount);
            }

            return vm;
        }

        private static UserAccountViewModel Map(UserAccount q)
        {
            return new UserAccountViewModel
            {
                Id = q.Id,
                Name = q.Name,
                Surname = q.Surname,
                Money = q.Money
            };
        }

        private IQueryable<UserAccount> GetUserAccounts()
        {
            return _context.UserAccounts.OrderBy(a => a.Id);
        }
    }
}

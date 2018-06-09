using System.Collections.Generic;
using StockMarket.Data.Models;
using System.Linq;
using StockMarket.ViewModels;

namespace StockMarket.Services
{
    public class InMemoryUserAccountData : IUserAccountData
    {
        private readonly List<UserAccount> _userAccounts;

        public InMemoryUserAccountData()
        {
            _userAccounts = new List<UserAccount>()
            {
                new UserAccount {Id = 1, Name = "Stock", Surname = "Market", Money = 100000000m}
            };
        }

        public IEnumerable<UserAccountViewModel> GetAllUserAccounts()
        {

        }

        private IQueryable<UserAccount> GetUserAccounts()
        {
            return _userAccounts.OrderBy(a => a.Id).AsQueryable();
        }

        public UserAccount Add(UserAccount userAccount)
        {
            userAccount.Id = _userAccounts.Max(u => u.Id) + 1;
            _userAccounts.Add(userAccount);

            return userAccount;
        }

 
    }
}

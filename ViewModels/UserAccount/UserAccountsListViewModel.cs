using System.Collections.Generic;

namespace StockMarket.ViewModels
{
    public class UserAccountsListViewModel
    {
        public UserAccountsListViewModel()
        {
            UserAccounts = new List<UserAccountViewModel>();
        }

        public List<UserAccountViewModel> UserAccounts;
    }
}

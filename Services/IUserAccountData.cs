using StockMarket.Data.Models;
using StockMarket.ViewModels;

namespace StockMarket.Services
{
    public interface IUserAccountData
    {
        UserAccountsListViewModel GetAllUserAccounts();
        UserAccount Add(UserAccount userAccount);
    }
}

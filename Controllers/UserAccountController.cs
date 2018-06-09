using Microsoft.AspNetCore.Mvc;
using StockMarket.Data.Models;
using StockMarket.Services;
using StockMarket.ViewModels;

namespace StockMarket.Controllers
{
    public class UserAccountController : Controller
    {
        private readonly IUserAccountData _userAccount;

        public UserAccountController(IUserAccountData userAccount)
        {
            _userAccount = userAccount;
        }

        public IActionResult Index()
        {
            var model = _userAccount.GetAllUserAccounts();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //always when post or auth cookies
        public IActionResult Create(UserAccountEditModel model)
        {
            if (ModelState.IsValid)
            {
                var newUserAccount = new UserAccount()
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    Money = model.Money
                };
                _userAccount.Add(newUserAccount);
                // prevents double posting on browser refresh
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
    }
}
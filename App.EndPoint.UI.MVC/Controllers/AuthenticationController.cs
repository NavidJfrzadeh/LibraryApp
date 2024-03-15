using App.Domain.Core.AdminEntity.Contracts;
using App.Domain.Core.CustomerEntity.Contracts;
using App.EndPoint.UI.MVC.Models;
using App.Infra.DataBase.MemoryDataBase;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.UI.MVC.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IAdminService _adminService;
        private readonly ICustomerService _customerService;

        public AuthenticationController(IAdminService adminService, ICustomerService customerService)
        {
            _adminService = adminService;
            _customerService = customerService;
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.IsAdmin)
            {
                var admin = _adminService.CheckLogin(model.Emai, model.Password);
                if (admin != null)
                {
                    MemoryDataBase.ActiveAdmin = admin;
                    ViewData["successLogin"] = "access Level Admin";
                    return RedirectToAction("Index", "Admin");
                }
            }

            var customer = _customerService.CheckLogin(model.Emai, model.Password);
            if (customer != null)
            {
                MemoryDataBase.ActiveCustomer = customer;
                ViewData["successLogin"] = "access level Customer";
                return RedirectToAction("Index", "Customer");
            }

            ViewData["failedLogin"] = "account not found";
            return View(model);
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}

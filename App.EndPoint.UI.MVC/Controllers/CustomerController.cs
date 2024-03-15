using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.UI.MVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BookDetails(int id)
        {
            return View();
        }


        [HttpGet]
        public IActionResult BorrowBook(int id)
        {
            return RedirectToAction("CustomerBooks");
        }

        public IActionResult CustomerBooks()
        {
            return View();
        }
    }
}

using App.Core;
using App.Domain.Core.AdminEntity.Contracts;
using App.Domain.Core.BookEntity.Contracts;
using App.Domain.Core.BookEntity.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.UI.MVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;
        private readonly IBookService _bookSerivce;
        public AdminController(IAdminService adminService, IBookService bookService)
        {
            _adminService = adminService;
            _bookSerivce = bookService;
        }


        public IActionResult Index()
        {
            var AllBooks = _bookSerivce.GetAll();
            return View(AllBooks);
        }


        public IActionResult BookDetails(int id)
        {
            var targetBook = _bookSerivce.GetById(id);
            return View(targetBook);
        }


        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(BookDTO bookModel)
        {
            _adminService.AddNewBook(bookModel);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteBook(int id)
        {
            _adminService.RemoveBook(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult EditBook(int id)
        {
            var targetBook = _bookSerivce.GetById(id);
            return View(targetBook);
        }

        [HttpPost]
        public IActionResult EditBook(Book book)
        {

            return RedirectToAction("Index");
        }
    }
}

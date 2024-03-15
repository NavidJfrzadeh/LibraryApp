using App.Domain.Core.BookEntity.Contracts;
using App.Domain.Core.CustomerEntity.Contracts;
using App.Domain.Services.BookEntity;
using App.Infra.DataBase.MemoryDataBase;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.UI.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IBookService _bookSrevice;
        public CustomerController(ICustomerService customerService, IBookService bookService)
        {
            _bookSrevice = bookService;
            _customerService = customerService;
        }


        public IActionResult Index()
        {
            var allBooks = _bookSrevice.NoneBorrowedBooks();
            return View(allBooks);
        }

        [HttpGet]
        public IActionResult BookDetails(int id)
        {
            var targetBook = _bookSrevice.GetById(id);
            return View(targetBook);
        }


        [HttpGet]
        public IActionResult BorrowBook(int id)
        {
            _customerService.BorrowBook(id, MemoryDataBase.ActiveCustomer.Id);
            return RedirectToAction("CustomerBooks");
        }

        public IActionResult CustomerBooks()
        {
            var books = _customerService.CustomerBooks(MemoryDataBase.ActiveCustomer.Id);
            return View(books);
        }

        public IActionResult ReturnBook(int id)
        {
            _customerService.ReturnBook(id, MemoryDataBase.ActiveCustomer.Id);
            return RedirectToAction("CustomerBooks");
        }
    }
}

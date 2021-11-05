using MVCBook.Data;
using MVCBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBook.Controllers
{
    public class BookController : Controller
    {
        private BookDbContext context = new BookDbContext();
        // GET: Book
        public ActionResult Index()
        {
            var books = context.Books.ToList();
            return View("Index", books);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Book book = new Book();
            return View("Create", book);
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            if(ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                return RedirectToAction("Index"); 
            }
            return View("Create", book); 
        }

        public ActionResult Detail(int id)
        {
            Book book = context.Books.Find(id);
            if (book != null)
            {
                return View("Detail", book);
            }
            else
            {
                return HttpNotFound();
            }
        }


    }
}
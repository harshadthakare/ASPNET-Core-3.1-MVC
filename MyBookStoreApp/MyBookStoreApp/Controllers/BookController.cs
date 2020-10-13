using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBookStoreApp.Models;
using MyBookStoreApp.Repository;

namespace MyBookStoreApp.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository bookRepository;
        public BookController()
        {
            bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = bookRepository.GetAllBooks();
            return View();
        }
        public BookModel GetBook(int id)
        {
            return bookRepository.GetBook(id);
        }

        public List<BookModel> SearchBook(string bookName,string author)
        {
            return bookRepository.SearchBook(bookName, author);
        }
    }
}
